using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab1.Models;


namespace Lab1.Models
{
    public class ManufacturerComparer<T> : IComparer<T> where T : Candy
    {
        public int Compare(T x, T y)
        {
            return x.Manufacturer.CompareTo(y.Manufacturer);
        }
    }
    public class PriceComparer<T> : IComparer<T> where T : Candy
    {
        public int Compare(T x, T y)
        {
            if (x.Price > y.Price)
                return 1;
            else if (x.Price < y.Price)
                return -1;
            else
                return 0;
        }
    }
    public class WeightComparer<T> : IComparer<T> where T : Candy
    {
        public int Compare(T x, T y)
        {
            if (x.Weight > y.Weight)
                return 1;
            else if (x.Weight < y.Weight)
                return -1;
            else
                return 0;
        }
    }
    public enum ChocolateKinds
    {
        Milk,
        White,
        Bitter
    }
    public enum MarshmallowKinds
    {
        Сylindrical,
        Pigtail,
        Long
    }
    public enum SweetKinds
    {
        Lolipop,
        Chocolate,
        Waffle,
        PigeonMilk,
        Roast
    }

}
