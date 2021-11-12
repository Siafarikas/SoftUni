using System;
using System.Collections.Generic;
using System.Text;

namespace GenericBox
{
    public class Box<T> where T : IComparable
    {
        public T Item { get; set; }

        public List<T> Items { get; }

        public Box(List<T> itemList)
        {
            Items = itemList;
        }

        public int CompareTo(T other) => Item.CompareTo(other);

        public int Count<T>(List<T> items, T item) where T : IComparable
        {
            List<T> output = new List<T>();
            output = items.FindAll(x => x.CompareTo(item) > 0);
            return output.Count;
        }


        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var item in Items)
            {
                sb.AppendLine($"{item.GetType()}: {item}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
