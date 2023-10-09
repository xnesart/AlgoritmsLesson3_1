using System;
using System.Collections;

namespace AlgoritmsLesson3_1
{
    public class HashTable<T> : IEnumerable
    {
        private T[] items;

        public HashTable(int size)
        {
            items = new T[size];
        }

        public void Add(T item)
        {
            var key = GetHash(item);
            if (items[key] == null)
            {
                items[key] = item;
            }
            else
            {
                while (items[key] != null && key < items.Length)
                {
                    if (key + 1 < items.Length) key++;
                    else key = 0;
                    if (items[key] == null && key < items.Length)
                    {
                        items[key] = item;
                        break;
                    }
                }
            }
        }

        public bool Remove(T item)
        {
            var key = GetHash(item);
            for (int i = key; i < items.Length; i++)
            {
                if (items[i] != null && items[i].Equals(item))
                {
                    items[i] = default(T);
                    return true;
                }
            }

            return false;
        }

        public bool Search(T item)
        {
            var key = GetHash(item);
            if (items[key] != null)
            {
                return items[key].Equals(item);
            }
            else return false;
        }

        private int GetHash(T item)
        {
            return item.ToString().Length % items.Length;
        }

        public void PrintTable(IEnumerator hashTableEnumerator)
        {
            while (hashTableEnumerator.MoveNext()) // пока не будет возвращено false
            {
                string item = (string)hashTableEnumerator.Current; // получаем элемент на текущей позиции
                if (item != null)
                {
                    Console.WriteLine(item);
                }
            }
        }


        public IEnumerator GetEnumerator()
        {
            return items.GetEnumerator();
        }
    }
}