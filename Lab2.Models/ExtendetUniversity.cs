using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Models
{
    public class ExtendetUniversity : University
    {
        public double P;

        public ExtendetUniversity(string name, uint firstAmount, uint graduatedAmount, double persent): base(name, firstAmount, graduatedAmount)
        {
            if (persent > 1 || persent < 0)
            {
                P = persent > 1 ? 1 : 0;
                return;
            }

            P = persent;
        }

        public override double Q()
        {
            return P * base.Q();
        }

        public override string GetQuality()
        {
            return $"Процент: {P}\r\n" +  $"Qp: {Q()}\r\n";
        }
        public override string ToString()
        {
            return  base.ToString();
        }

    }
}
