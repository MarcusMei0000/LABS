using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab5.Models
{
    // определим абстаркный класс модели, от которого будут наследоваться все модели
    public abstract class Model
    {
        // X, Y потом для отрисовке на формах
        // задаётся здесь, так как поведение моеделей задаётся здесь
        public float X { get; internal set; }
        public float Y { get; internal set; }

        // флаг чтобы знать модель сейчас ничем не занята, не перемещать координаты
        public bool IsLocked { get; internal set; }

        // флаг, чтобы контролировать нужно ли ещё совершать действия в потоке
        public bool IsCanceled { get; set; }

        // метод модели для запуска в потоке
        public abstract void Start();

        // определим событие уведомление, чтобы выводить результаты на форму или куда-то ещё
        public Action<string> Notification;

        public Model(Action<string> Notification)
        {
            this.Notification = Notification;
        }
    }
}
