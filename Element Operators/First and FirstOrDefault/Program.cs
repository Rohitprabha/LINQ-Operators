using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Operators___Element_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("using First");
            int MethodSyntax = numbers.First();
            Console.WriteLine(MethodSyntax);
            Console.WriteLine("using FirstOrDefault");
            int MethodSyntax1 = numbers.FirstOrDefault(num => num > 5);
            Console.WriteLine(MethodSyntax1);
            Console.ReadLine();
        }
    }
}
