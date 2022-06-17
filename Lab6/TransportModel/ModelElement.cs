using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Laba_5.model
{
    // элемент модели
    public abstract class ModelElement : IModelElement
    {
        // точка, в которой элемент будет отрисовываться
        private Point point;
        // признак того, что элемент заблокирован
        private bool isLocked;
        // признак того, что элемент остановлен
        private bool isStopped;
        // текстовое уведомление
        private Action<string> notification;

        public Point Point { get { return point; } set { point = value; } }
        public bool IsLocked { get { return isLocked; } set { value = isLocked; } }
        public bool IsStopped { get { return isStopped; } set { value = isStopped; } }
        public Action<string> Notification { get { return notification; } }

        public ModelElement(Action<string> notification)
        {
            this.isLocked = false;
            this.isStopped = false;
            this.notification = notification;
        }

        public abstract void Start();
    }
}
