using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Operators___Ordering_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int>() { 10, 45, 35, 29, 100, 69, 58, 50 };
            Console.WriteLine("Before Sorting : ");
            foreach (var item in intList)
            {
                Console.Write(item + " ");
            }
            //Sorting the data in Ascending Order

            var MS = intList.OrderBy(num => num);                   //Using Method Syntax

            var QS = (from num in intList                           //Using Query Syntax
                      orderby num
                      select num).ToList();
            Console.WriteLine();
            Console.WriteLine("After Sorting : ");
            foreach (var item in QS)
            {
                Console.Write(item + " ");
            }
            Console.ReadLine();
        }
    }
}
