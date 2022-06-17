using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab5.Models
{
    // интерфейс для элемента модели
    public interface IModelElement
    {
        // старт элемента
        public abstract void Start();
    }
}
