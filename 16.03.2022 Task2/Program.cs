using System;
using System.Collections;

namespace _16._03._2022_Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList sortedList = new SortedList();
            sortedList.Add(1985,"C++");
            sortedList.Add(1984, "Python");
            sortedList.Add(1995, "C#");
            foreach (DictionaryEntry item in sortedList)
            {
                Console.WriteLine(item.Key +" "+ item.Value);
            }
            SortedList sortedList1 = new SortedList();
            sortedList1.Add("Python", 1984);
            sortedList1.Add("A#",1995);
            sortedList1.Add("C++",1985);
            foreach (DictionaryEntry item in sortedList1)
            {
                Console.WriteLine(item.Value + " " + item.Key);
            }
        }
    }
}
