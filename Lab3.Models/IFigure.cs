using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Models
{
    //17.  interface Фигура -> abstract class Геометрическая фигура -> class Ромб.
    public interface IFigure
    {
        double Area { get; set; }
        double CountArea();
        void Copy(IFigure other);
    }
}
