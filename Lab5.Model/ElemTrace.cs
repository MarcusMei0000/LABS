using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab5.Models
{
    // абстрактный класс для работы с траекторией движения элемента
    public abstract class ElemTrace
    {
        // начальная точка
        protected Point fromPoint;
        // конечная точка
        protected Point toPoint;

        // шаг по оси Х
        protected int stepX;
        // шаг по оси У
        protected int stepY;

        // количество шагов
        protected int stepCount;

        public ElemTrace(Point fromPoint, Point toPoint)
        {
            this.fromPoint = fromPoint;
            this.toPoint = toPoint;
            this.stepCount = 15;
            this.stepX = Math.Abs(fromPoint.X - toPoint.X) / stepCount;
            this.stepY = Math.Abs(fromPoint.Y - toPoint.Y) / stepCount;
        }

        // получение следующей точки
        public abstract Point NextPoint(Point point);

        // метод для вычисления расстояния между точками
        protected static double Distance(Point p1, Point p2)
        {
            return Math.Round(Math.Sqrt(Math.Pow((p2.X - p1.X), 2) + Math.Pow((p2.Y - p1.Y), 2)), 1);
        }
    }
}
