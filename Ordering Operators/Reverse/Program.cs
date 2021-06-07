using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Operators___Ordering_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[] { 10, 30, 50, 40, 60, 20, 70, 100 };
            Console.WriteLine("Before Reverse the Data");
            foreach (var number in intArray)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            IEnumerable<int> ArrayReversedData = intArray.Reverse();
            Console.WriteLine("After Reverse the Data");
            foreach (var number in ArrayReversedData)
            {
                Console.Write(number + " ");
            }

            Console.ReadKey();
        }
    }
}
