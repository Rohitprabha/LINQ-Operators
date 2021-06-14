using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Operators___Filtering_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Method Syntax
            IEnumerable<int> filteredData = intList.Where(num => num > 5);
            //Query Syntax
            IEnumerable<int> filteredResult = from num in intList
                                              where num > 5
                                              select num;

            foreach (int number in filteredData)
            {
                Console.WriteLine(number);
            }
            Console.ReadKey();
        }
    }
}
