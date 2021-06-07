using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Operators____Generation_1
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> numberSequence = Enumerable.Range(1, 10);
            foreach (int i in numberSequence)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
