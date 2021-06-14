using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;



namespace LINQ_Operators____Conversion_4
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add(2);
            al.Add(4);
            al.Add(6);
            al.Add(8);
            al.Add("9");
            IEnumerable<int> numbers = al.OfType<int>();
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
