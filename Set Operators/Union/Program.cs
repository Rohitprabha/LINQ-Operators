using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Operators___Set_4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> dataSource1 = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
            List<int> dataSource2 = new List<int>() { 1, 3, 5, 8, 9, 10 };
            //Method Syntax
            var MS = dataSource1.Union(dataSource2).ToList();
            //Query Syntax
            var QS = (from num in dataSource1
                      select num)
                      .Union(dataSource2).ToList();
            foreach (var item in MS)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
