using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace StartUp
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private List<T> Collection;

        private int Index;



        public ListyIterator(params T[] elements)
        {
            Collection = new List<T>(elements);
            Index = 0;
        }


        public bool HasNext() => Index < Collection.Count - 1;

        public bool Move()
        {
            bool canMove = this.HasNext();
            if (canMove)
            {
                Index++;
            }
            return canMove;
        }

        public void Print()
        {
            if (Collection.Count > 0)
            {
                Console.WriteLine(Collection[Index]);
            }
            else
            {
                Console.WriteLine("Invalid Operation!");
            }
        }

        public void PrintAll()
        {
            if (Collection.Count > 0)
            {
                Console.WriteLine(string.Join(" ", Collection));
            }
            else
            {
                Console.WriteLine("Invalid Operation!");
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T element in Collection)
            {
                yield return element;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
