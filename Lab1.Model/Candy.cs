using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Lab1.Models
{
    public abstract class Candy
    {
        public decimal Weight { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public decimal SugarContent { get; set; }

        public Candy()
        {
            Name = "default";
            Weight = 0;
            Manufacturer = "default";
            SugarContent = 0;
        }

        public Candy (string name, decimal weight, double price, decimal sugarContent, string manufacturer)
        {
            Name = name;
            Weight = weight;
            Price = price;
            SugarContent = sugarContent;
            Manufacturer = manufacturer;
        }

        public abstract string GetFullInfo();

        public override string ToString()
        {
            return $"Название: {Name}" + "\r\n" +
                $"Вес: {Weight}" + "\r\n" +
                $"Цена: {Price}" + "\r\n" +
                $"Содержание сахара: {SugarContent}" + "\r\n" +
                $"Производитель: {Manufacturer}" + "\r\n" +
                GetFullInfo();
        }
    }
}
