using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Lab1.Models
{
    public class Chocolate : Candy
    {
        public decimal CacaoPercent { get; set; }
        public string Kind { get; set; }
        public Chocolate()
        {
            CacaoPercent = 0;
            Kind = "White";
        }

        public Chocolate(string name, decimal weight, double price, decimal sugarContent, string manufacturer, decimal cacaoPercent, ChocolateKinds kind)
            : base (name, weight, price, sugarContent, manufacturer)
        {
            CacaoPercent = cacaoPercent;
            Kind = kind.ToString();
        }

        public override string GetFullInfo()
        {
            return $"Процент какао: {CacaoPercent}\r\n" + $"Вид шоколада: {Kind}\r\n";
        }
    }
}
