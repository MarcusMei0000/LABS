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
        // список обслуживаемых троллейбусов
        private List<Car> trolleys;
        // троллейбус, который ремонтируется в данный момент
        private Car? brokenTrolley;

        public List<Car> Trolleys { get { return trolleys; } set { trolleys = value; } }

        public EmergencyService(Action<string> notification, List<Car> cars, Point point) : base(notification)
        {
            this.Point = point;
            this.trolleys = cars;
        }

        // ремонт троллейбуса
        private void RepairTrolley()
        {
            // запоминаем точку, в которую должны вернуться
            Point defaultPoint = this.Point;
            OneWayTrace trace;
            // если есть, что ремонтировать
            if (brokenTrolley != null)
                lock (trolleys)
                {
                    // создаем траекторию из начальной точки к задней части троллейбуса
                    trace = new OneWayTrace(this.Point, new Point(brokenTrolley.Point.X + 100, brokenTrolley.Point.Y + 50));
                    // проходим по траектории
                    while (!trace.IsFinished)
                    {
                        this.Point = trace.NextPoint(this.Point);
                        Task.Delay(200).Wait();
                    }
                    // отмечаем, что троллейбус отремонтирован
                    brokenTrolley.Repair();
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
                lock (trolleys)
                {
                    brokenTrolley = trolleys.FirstOrDefault
                        (trolley => trolley.IsBroken && !trolley.EmergencyAppointed);
                }
                if (brokenTrolley != null)
                {
                    brokenTrolley.EmergencyAppointed = true;
                    IsLocked = true;
                    Notification($"Аварийная служба отправлена на ремонт троллейбуса номер {brokenTrolley.Number}");
                    elemAction = RepairTrolley;
                }

            }
        }
    }
}
