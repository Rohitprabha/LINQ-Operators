using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Operators___Partitioning_4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> ResultMS = numbers.SkipWhile(num => num < 5).ToList();
            foreach (var num in ResultMS)
            {
                Console.Write($"{num} ");
            }
            Console.ReadKey();
        }
    }
}
