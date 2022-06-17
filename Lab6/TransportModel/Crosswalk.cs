using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Laba_5.model
{
    public class Crosswalk : ModelElement
    {
        // номер пешеходного перехода
        private int number;
        public int Number { get { return number; } }

        private void RandomBreak(Random random)
        {
            if (!IsLocked && random.Next(0, 10) < 1)
            {                
                //IsLocked = true;
                //Notification($"Машина номер {number} сломан");
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

        public Crosswalk(int number, Point point, Action<string> notification) : base(notification)
        {
            this.number = number;
            this.Point = point;
        }
    }
}
