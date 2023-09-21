using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Policy;

namespace AlgoritmsLesson3_1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            HashTable<string> hashTable = new HashTable<string>(20);
            hashTable.Add("'Водоросли': 280");
            hashTable.Add("'Картофель': 260");
            hashTable.Add("'Лук-порей': 59");
            hashTable.Add("'Манго': 291");
            hashTable.Add("'Орехи грецкие': 266");
            hashTable.Add("'Салями': 225");
            hashTable.Add("'Специи': 283");
            hashTable.Add("'Сыр сливочный': 152");
            hashTable.Add("'Творог': 215");
            hashTable.Add("'Тофу': 142");
            hashTable.Add("'Хек': 248");
            hashTable.Add("'Чай черный': 118");
            hashTable.Add("'Чернила каракатицы': 95");
            hashTable.Add("'Шампиньоны': 101");
            hashTable.Add("'Финик': 104");

            Console.WriteLine(hashTable.Search("'Водоросли': 280"));
            //Console.WriteLine(isBe);
            IEnumerator hashTableEnumerator = hashTable.GetEnumerator(); // получаем IEnumerator
            //hashTable.PrintTable(hashTable,hashTableEnumerator);
            hashTableEnumerator.Reset(); // сбрасываем указатель в начало массива


            Console.WriteLine(hashTable);
        }
    }
}