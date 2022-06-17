using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Lab1.Models
{
    public class Sweet : Candy
    {
        public string Kind { get; set; }
        public bool HasStick { get; set; }
        public Sweet()
        {
            Kind = "Lolipop";
            HasStick = true;
        }

        public Sweet(string name, decimal weight, double price, decimal sugarContent, string manufacturer, SweetKinds kind, bool stick)
            : base(name, weight, price, sugarContent, manufacturer)
        {
            Kind = kind.ToString();
            HasStick = stick;
        }

        public override string GetFullInfo()
        {
            return $"Вид конфеты: {Kind}"+ "\r\n" + $"Наличие палочки: {HasStick}" + "\r\n";
        }
    }
}
