using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Laba_5.model
{
    // аварийная служба
    public class EmergencyService : ModelActingElement
    {
        // список обслуживаемых
        private List<Car> cars;
        // троллейбус, который ремонтируется в данный момент
        private Car? brokenCar;

        public List<Car> Cars { get { return cars; } set { cars = value; } }

        public EmergencyService(Action<string> notification, List<Car> cars, Point point) : base(notification)
        {
            this.Point = point;
            this.cars = cars;
        }

        // ремонт
        private void RepairCar()
        {
            // запоминаем точку, в которую должны вернуться
            Point defaultPoint = this.Point;
            OneWayTrace trace;
            // если есть, что ремонтировать
            if (brokenCar != null)
                lock (cars)
                {
                    // создаем траекторию из начальной точки к задней части
                    trace = new OneWayTrace(this.Point, new Point(brokenCar.Point.X + 100, brokenCar.Point.Y + 50));
                    // проходим по траектории
                    while (!trace.IsFinished)
                    {
                        this.Point = trace.NextPoint(this.Point);
                        Task.Delay(200).Wait();
                    }
                    // отмечаем, что отремонтирован
                    brokenCar.Repair();
                }
            // создаем траекторию из текущего положения в начальное
            trace = new OneWayTrace(this.Point, defaultPoint);
            // проходим по траектории
            while (!trace.IsFinished)
            {
                this.Point = trace.NextPoint(this.Point);
                Task.Delay(200).Wait();
            }
            // снимаем блок
            IsLocked = false;
            elemAction = null;
        }

        protected override void CheckEvents()
        {
            if (!IsLocked)
            {
                lock (cars)
                {
                    brokenCar = cars.FirstOrDefault
                        (car => car.IsBroken && !car.EmergencyAppointed);
                }
                if (brokenCar != null)
                {
                    brokenCar.EmergencyAppointed = true;
                    IsLocked = true;
                    Notification($"Аварийная служба отправлена на ремонт машины номер {brokenCar.Number}");
                    elemAction = RepairCar;
                }

            }
        }
    }
}
