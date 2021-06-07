using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Operators____Generation_3
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<string> repeatStrings = Enumerable.Repeat("Hai There!", 10);
            foreach (String str in repeatStrings)
            {
                Console.WriteLine(str);
            }
            Console.ReadKey();
        }
    }
}
