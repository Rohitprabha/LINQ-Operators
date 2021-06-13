using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Operators___Element_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("using ElementAt");
            int MethodSyntax = numbers.ElementAt(1);
            Console.WriteLine(MethodSyntax);
            Console.WriteLine("using ElementAtOrDefault");
            int MethodSyntax1 = numbers.ElementAtOrDefault(10);
            Console.WriteLine(MethodSyntax1);

            Console.ReadLine();
        }
    }
}
