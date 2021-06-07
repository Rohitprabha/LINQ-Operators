using System;
using System.Collections.Generic;
using System.Linq;


namespace LINQ_Operators___Element_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { };
            IEnumerable<int> result = numbers.DefaultIfEmpty();
            foreach (int num in result)
            {
                Console.WriteLine(num);
            }
            Console.ReadLine();
        }
    }
}
