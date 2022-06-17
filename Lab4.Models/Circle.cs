using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Models
{
    public class Circle : GeometricFigure
    {
        public double CountSectorArea(double angle = 10)
        {
            return Math.PI * Length * Length * angle / 360;
        }

        public override double CountArea() 
        {
            return Math.PI * Length * Length;
        }
        public override double CountPerimeter()
        {
            return 2 * Math.PI * Length;
        }
    }
}
