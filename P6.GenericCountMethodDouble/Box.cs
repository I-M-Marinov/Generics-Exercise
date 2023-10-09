using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P6.GenericCountMethodDouble
{
    internal class Box<T> where T : IComparable<T>
    {

        private List<T> items;

        public Box()
        {
            items = new List<T>();
        }

        public void Add(T item)
        {
            items.Add(item);
        }

        public int Count(T itemToCompare)
        {
            int count = 0;

            foreach (T item in items)
            {
                if (item.CompareTo(itemToCompare) > 0)
                {
                    count++;
                }
            }

            return count;
        }
        public override string ToString()
        {
            StringBuilder sb = new();

            foreach (T item in items)
            {
                sb.AppendLine($"{typeof(T)}: {item.ToString()}");
            }

            return sb.ToString().TrimEnd();
        }


    }
}
