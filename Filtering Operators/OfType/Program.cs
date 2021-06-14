using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Operators___Filtering_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> dataSource = new List<object>()
            {
                "Tom", "Mary", 50, "Prince", "Jack", 10, 20, 30, 40, "James"
            };

            List<int> intData = dataSource.OfType<int>().ToList();

            foreach (int number in intData)
            {
                Console.Write(number + " ");
            }

            Console.ReadKey();
        }
    }
}
