using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab5.Models
{
    class Crosswalk : ModelElement
    {
        // номер пешеходного перехода
        private int number;

        private Point locatoin;
        public int Number { get { return number; } }
        public bool IsGreen { get { return IsGreen; } }
        public Point Locatoin { get { return locatoin; } }


        private void RandomBreak(Random random)
        {
            if (!IsLocked && random.Next(0, 10) < 1)
            {                
                IsLocked = true;
                Notification($"Машина номер {number} сломан");
            }
        }

        public override void Start()
        {
           Random random = new Random();
           while (!IsStopped)
            {
                Task.Delay(200).Wait();
                if (!IsLocked)
                    RandomBreak(random);
            }
        }

        public Crosswalk(int number, bool isGreen, Point point, Action<string> notification) : base(notification)
        {
            this.number = number;
            this.locatoin = point;
        }
    }
}
