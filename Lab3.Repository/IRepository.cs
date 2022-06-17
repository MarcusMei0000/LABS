using Lab3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Repository
{
    // Работа со списком объектов, который должен содержать объекты типа интерфейса
    public interface IRepository
    {
        IEnumerable<Item> GetAll();
        Item Get(int id);
        void Add(Item item);
        void Update(Item item);
        void Delete(int id);
    }
}
