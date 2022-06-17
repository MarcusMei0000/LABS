using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Models
{
    //Абстрактный класс должен содержать 3-5 свойств и 3-5 методов(включая унаследованные свойства интерфейса).   

    //унаследованные свойства - Area, свои Length, Angle = 3 всего
    // методы унаследванные CountArea, Copy, свои - CountPerimeter = 3 всего


    // абстрактный класс Геометрическая фигура
    public abstract class GeometricFigure : IFigure
    {
        private double _area;
        private double _length;
        private double _angle;

        public double Area
        {
            get => _area;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Указана отрицательная площадь");

                _area = value;
            }
        }

        public double Length
        {
            get => _length;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Указана отрицательная высота");

                _length = value;
            }
        }

        public double Angle
        {
            get => _angle;
            set
            {
                if (value < 0 || _angle > 360)
                    throw new ArgumentException("Указан неверный угол");

                _angle = value;
            }
        }

        // Подсчёт площади и периметра зависит от типа фигуры
        public abstract double CountArea();
        public abstract double CountPerimeter();

        public void Copy(IFigure other)
        {
            Area = other.Area;
            
            // так как на вход интерфейс, проверим, что это явлеятся типом шкаф
            if (other is GeometricFigure)
            {
                // это тип шкаф, коипруем инфу
                GeometricFigure gFigure = other as GeometricFigure;
                Length = gFigure.Length;
                Angle = gFigure.Angle;
            }
        }

        
    }
}
