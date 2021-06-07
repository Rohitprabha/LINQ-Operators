using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Operators____Conversion_5
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList
            {
                10,
                20,
                30,
                "50"
            };
            IEnumerable<int> result = list.Cast<int>();
            foreach (int i in result)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
