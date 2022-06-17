using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Models
{
    public class Triangle : GeometricFigure
    {
        public double Side { get; set; }

        //Найти третью сторону треугольника
        public double CountThirdSide()
        {
            return Math.Sqrt(Length*Length + Side*Side - 2*Length*Side*Math.Cos(Angle*Math.PI*180));
        }
        public double CountSecondAngle()
        {
            double side = CountThirdSide();
            return Math.Acos((Side * Side + side * side - Length * Length) / 2 * Side * side)*180.0/Math.PI;
        }
        public double CountThirdAngle()
        {
            double secondAngle = CountSecondAngle();
            return 180 - Angle - secondAngle;
        }

        public override double CountArea()
        {
            return Length * Side * Math.Sin(Angle * Math.PI * 180);
        }
        public override double CountPerimeter()
        {
            double side = CountThirdSide();
            return Length * Side * side;
        }
        public override void Copy(IFigure other)
        {
            base.Copy(other);

            if (other is Triangle triangle)
            {
                Side = triangle.Side;
            }
        }
    }
}
