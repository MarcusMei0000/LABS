using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laba_5.model;
using System.Drawing;

namespace Laba_5.UI
{
    // класс для отрисовки модели
    public class ModelPresenter
    {
        // канва
        private readonly Graphics graphics;
        // список элементов для отрисовки
        private List<VisualElement> elems;
        // таймер
        private System.Windows.Forms.Timer timer;

        public ModelPresenter(PictureBox pictureBox, List<VisualElement> elems)
        {
            Bitmap bitmap = new(pictureBox.Width, pictureBox.Height);
            graphics = Graphics.FromImage(bitmap);

            timer = new System.Windows.Forms.Timer
            {
                Interval = 30
            };

            this.elems = elems;
            // событие на тик таймера для перерисовки всех элементов модели
            timer.Tick += new EventHandler((obj, e) =>
            {
                graphics.Clear(pictureBox.BackColor);
                foreach (var elem in this.elems)
                {
                    Draw(elem);
                }
                pictureBox.Image = bitmap;
            });
        }
        public void AddVisualElem(VisualElement elem)
        {
            if (elems != null)
                lock (elems)
                {
                    elems.Add(elem);
                }
        }

        private void Draw(VisualElement elem)
        {
            graphics.DrawImage(elem.Image,
                elem.ModelElement.Point.X - elem.Image.Width / 2, elem.ModelElement.Point.Y - elem.Image.Height / 2);
        }

        public void Start()
        {
            timer.Start();
        }

        public void Stop()
        {
            timer.Stop();
        }
    }
}
