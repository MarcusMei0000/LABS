using Lab1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Models
{
    public static class CandyFilters
    {
        //возвращает все конфеты заданного производителя
        public static IEnumerable<Candy> ManufacturerFilter(List<Candy> candyList, params string[] manufacturers)
        {
            foreach (var candy in candyList)
            {
                for (int i = 0; i < manufacturers.Length; i++)
                {
                    if (candy.Manufacturer == manufacturers[i]) {
                        yield return candy;
                        break;
                    }
                }
            }
        }

        //возвращает все конфеты заданного диапозона цен
        public static List<Candy> PriceFilter(List<Candy> candies, double min, double max)
        {
            return candies.Where(x => x.Price >= min && x.Price < max).ToList();
        }

        //возвращает все конфеты заданного диапозона веса
        public static List<Candy> WeightFilter(List<Candy> candies, decimal min, decimal max)
        {
            return candies.Where(x => x.Weight >= min && x.Weight < max).ToList();
        }

        //возвращает все конфеты заданного диапозона сахара
        public static List<Candy> SugarFilter(List<Candy> candies, decimal min, decimal max)
        {
            return candies.Where(x => x.Weight >= min && x.Weight < max).ToList();
        }
    }
}
