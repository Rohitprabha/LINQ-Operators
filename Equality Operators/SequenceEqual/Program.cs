using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Operators___Equality
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cityList1 = new List<string> { "Delhi", "Mumbai", "Hyderabad" };
            List<string> cityList2 = new List<string> { "Delhi", "Mumbai", "Hyderabad" };
            bool IsEqual = cityList1.SequenceEqual(cityList2);
            Console.WriteLine(IsEqual);
            Console.ReadLine();
        }
    }
}
