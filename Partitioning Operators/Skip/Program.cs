using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Operators___Partitioning_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> ResultMS = numbers.Skip(4).ToList();
            foreach (var num in ResultMS)
            {
                Console.Write(num + " ");
            }
            Console.ReadKey();
        }
    }
}
