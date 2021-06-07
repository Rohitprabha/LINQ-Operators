using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Operators____Conversion_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> BrandList = new List<string>() { "Apple", "Microsoft", "Google", "Samsung", "Sony" };
            //retrieve items from the list in ascending order and convert them to array  
            string[] brandArray = (from brand in BrandList
                                   orderby brand ascending
                                   select brand).ToArray();
            foreach (string item in brandArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
