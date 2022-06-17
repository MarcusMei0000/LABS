using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Lab5.Models;

namespace Lab5.Main
{
    // класс для рисования объектов
    // хранит изборажение и координаты отрисовки
    // хранит коордианыт центра фигуры
    class ViewObject
    {
        // коордианты объекта
        // virtual чтобы ViewModel : ViewObject давал коордианты модели
        public virtual float X { get; set; }
        public virtual float Y { get; set; }

        public Image Image { get; set; }

        // по типу модели определим изображение и описание
        public ViewObject(Image image)
        {
            this.Image = image;
        }

        public ViewObject(Image image, float x, float y)
        {
            this.Image = image;
            X = x;
            Y = y;
        }
    }
}
