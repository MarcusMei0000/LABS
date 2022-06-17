using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Laba_5.model
{
    public class Car : ModelElement
    {
        private bool isBroken;
        private bool emergencyAppointed;
        // номер машины
        private int number;
        private CarTrace trace;

        public bool IsBroken { get { return isBroken; } }
        public bool EmergencyAppointed { get { return emergencyAppointed; } set { emergencyAppointed = value; } }
        public int Number { get { return number; } }

        public Car(int number, Action<string> notification, Point point, CarTrace trace) : base(notification)
        {
            this.Point = point;
            isBroken = false;
            this.number = number;
            this.trace = trace;
        }

        // генерация поломки
        private void RandomBreak(Random random)
        {
            if (!IsLocked && random.Next(0, 10) < 1)
            {
                isBroken = true;
                IsLocked = true;
                Notification($"Машина номер {number} сломан");
            }
        }

        // починить
        public void Repair()
        {
            isBroken = false;
            IsLocked = false;
            emergencyAppointed = false;
            Notification($"Машина номер {number} отремонтирован");
        }

        public void Move()
        {
            this.Point = trace.NextPoint(this.Point);
        }

        public override void Start()
        {
            Random random = new Random();
            while (!IsStopped)
            {
                Task.Delay(200).Wait();
                if (!IsLocked && !IsBroken)
                    RandomBreak(random);
                if (!IsLocked && !IsBroken)
                    Move();
            }
        }
    }
}
