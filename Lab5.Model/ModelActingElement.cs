using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab5.Models
{
    // абстрактный класс для элемента модели, совершающего действия
    public abstract class ModelActingElement : ModelElement
    {
        // действие элемента модели
        protected Action? elemAction;
        // проверка наличия ожидающих событий
        protected abstract void CheckEvents();
        protected ModelActingElement(Action<string> notification) : base(notification)
        {
            elemAction = null;
        }
        public override void Start()
        {
            while (!IsStopped)
            {
                CheckEvents();
                elemAction?.Invoke();
                Task.Delay(30).Wait();
            }
        }
    }
}
