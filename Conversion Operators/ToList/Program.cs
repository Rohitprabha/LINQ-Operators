using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Operators____Conversion_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            //convert array to list which will return list of integers  
            List<int> listNumber = numbers.ToList();
            //loop thru each list item  
            foreach (int item in listNumber)
            {
                Console.WriteLine(item);
            }
        }
    }
}
