using System;
using System.Linq;

namespace LINQ_Operators___Quantifier_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] IntArray = { 11, 22, 33, 44, 55 };
            var Result = IntArray.All(x => x > 10);
            Console.WriteLine("Is All Numbers are greater than 10 : " + Result);
            Console.ReadKey();
        }
    }
}
