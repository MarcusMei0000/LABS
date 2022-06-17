using Lab3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Repository
{
    public class Item
    {
        public IFigure figure;
        public int index;
        public Item()
        {
            figure = null;
            index = 0;
        }
        public Item(IFigure f, int i)
        {
            figure = f;
            index = i;
        }
        public void Copy(Item other)
        {
            figure = other.figure;
            index = other.index; 
        }
    }
    //реализация через List
    public class ListRepository : IRepository
    {
        List<Item> _repository;

        public ListRepository()
        {
            _repository = new List<Item>();
        }

        public Item Get(int id)
        {
            var item = _repository.FirstOrDefault(elem => elem.index == id);

            if (item == null)
                throw new ArgumentException("Не найден Id");

            return item;
        }

        public IEnumerable<Item> GetAll()
        {
            return _repository;
        }

        public void Delete(int id)
        {
            var itemToDelete = Get(id);
            _repository.Remove(itemToDelete);
        }

        public void Update(Item item)
        {
            var itemToUpdate = Get(item.index);
            itemToUpdate.Copy(item);
        }

        public void Add(Item item)
        {
            /*if (_repository.Count == 0)
                item.index = 1;
            else
                item.index = _repository.Max(elem => elem.index) + 1;*/

            item.index = _repository.Count == 0 ? 1 : _repository.Max(elem => elem.index) + 1;
            _repository.Add(item);
        }
    }
}
