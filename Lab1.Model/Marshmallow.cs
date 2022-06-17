using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Lab1.Models
{
    public class Marshmallow : Candy
    {
        public string Type { get; set; }
        public int Color { get; set; }
        public Marshmallow()
        {
            Type = "Сylindrical";
            Color = 0;
        }

        public Marshmallow(string name, decimal weight, double price, decimal sugarContent, string manufacturer, MarshmallowKinds type, int color)
            : base(name, weight, price, sugarContent, manufacturer)
        {
            Type = type.ToString();
            Color = color;
        }
        public override string GetFullInfo()
        {
            return $"Тип: {Type}"+ "\r\n" + $"Цвет: {Color}" + "\r\n";
        }
    }
}
