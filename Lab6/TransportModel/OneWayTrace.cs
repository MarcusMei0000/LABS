using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Laba_5.model
{
    // траектория в один конец
    public class OneWayTrace : ElemTrace
    {
        // признак того, что траектория пройдена
        private bool isFinished;

        public bool IsFinished { get { return isFinished; } }

        public OneWayTrace(Point fromPoint, Point toPoint) : base(fromPoint, toPoint)
        {
            isFinished = false;
        }

        public override Point NextPoint(Point point)
        {
            int signX = Math.Sign(toPoint.X - fromPoint.X);
            int signY = Math.Sign(toPoint.Y - fromPoint.Y);

            int newX = point.X + signX * stepX;
            int newY = point.Y + signY * stepY;

            Point newPoint = new Point(newX, newY);
            // считаем, что траектория пройдена, если расстояние между текущим и конечным положением мало
            isFinished = (Distance(newPoint, toPoint) < (stepX + stepY));
            return newPoint;
        }
    }
}
