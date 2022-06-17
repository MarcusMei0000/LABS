using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Models
{
    // класс для отрисовки одного элемента модели
    public class VisualElement
    {
        private ModelElement modelElem;
        public Image Image { get; set; }
        public ModelElement ModelElement { get { return modelElem; } }
        public VisualElement(ModelElement modelElem, Image image)
        {
            this.modelElem = modelElem;
            this.Image = image;
        }
    }
}