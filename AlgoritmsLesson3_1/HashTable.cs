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
            items[key] = null;
            if (items[key] != null && items[key].Equals(item) )
            {
                key = null;
            }
            else return false; 
        }
        public bool Search(T item)
        {
            var key = GetHash(item);
            if (items[key] != null)
            {
                return items[key].Equals(item);
            }
            else return false;
            //Console.WriteLine(items[key]);
        }

        private int GetHash(T item)
        {
            return item.ToString().Length % items.Length;
        }

        public void PrintTable(HashTable<T> hashTable, IEnumerator hashTableEnumerator)
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