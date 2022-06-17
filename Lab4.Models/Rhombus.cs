using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Models
{
    //Класс должен содержать дополнительно 2 свойства и 2 метода.

    // 2 свойства - isFull, Height
    // 2 метода - узнать кол-во книг

    //Ромб
    public class Rhombus : GeometricFigure
    {
        //Определяет является ли ромб контуром или заполненной фигурой
        public bool isFull { get; set; }

        //высота ромба

        private double _height;

        public double Height
        {
            get => _height;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Указано отрицательное число");

                _height = value;
            }
        }

        public override double CountArea()
        {
            return Height * Length;
        }
        public override double CountPerimeter()
        {
            return 4 * Length;
        }


        //какая станет площадь ромба, если изменить его угол
        public double CountAreaWithAngle(double angle = 45)
        {
        return Length * Length * Math.Sin(angle);
        }

        //какая станет площадь ромба, если изменить его высоту
        public double CountAreaWithHeight(double height = 10)
        {
            return height * Length;
        }

        public override void Copy(IFigure other)
        {
            base.Copy(other);

            if (other is Rhombus)
            {
                Rhombus otherBookCase = other as Rhombus;
                isFull = otherBookCase.isFull;
                Height = otherBookCase.Height;
            }
        }
    }
}
