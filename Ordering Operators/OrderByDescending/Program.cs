using System;
using System.Collections.Generic;
using System.Linq;
namespace LINQDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int>() { 10, 45, 35, 29, 100, 69, 58, 50 };
            Console.WriteLine("Before Sorting the Data: ");
            foreach (var item in intList)
            {
                Console.Write(item + " ");
            }
            //Sorting the data in Descending Order
            //Using Method Syntax
            var MS = intList.OrderByDescending(num => num);
            //Using Query Syntax
            var QS = (from num in intList
                      orderby num descending
                      select num).ToList();
            Console.WriteLine();
            Console.WriteLine("After Sorting the Data in Descending Order: ");
            foreach (var item in QS)
            {
                Console.Write(item + " ");
            }
            Console.ReadKey();
        }
    }
}