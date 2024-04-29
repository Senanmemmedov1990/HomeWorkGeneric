using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkGeneric
{
    public class CustomCollection<T> where T : Person
    {
        private T[] items = new T[0];
        private int index = 0;

        public void Add(T item)
        {
            Array.Resize(ref items, items.Length + 1);
            items[items.Length -1] = item;
        }
        public void GetAll()
        {
            foreach (T item in items)
            {
                Console.WriteLine($"{item.Id}, {item.Name},{item.SurName}, {item.Age}");
            }
        }
        public T FindById(int id)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i].Id == id)
                {
                    return items[i];
                }
            }
            return null;
        }
    }
}
