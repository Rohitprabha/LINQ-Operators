using System;
using System.Linq;

namespace LINQ_Operators___Quantifier_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] IntArray = { 11, 22, 33, 44, 55 };
            //Using Method Syntax
            var ResultMS = IntArray.Any();
            //Using Query Syntax
            var ResultQS = (from num in IntArray select num).Any();
            Console.WriteLine("Is there any element in the collection : " + ResultMS);
            Console.ReadKey();
        }
    }
}
