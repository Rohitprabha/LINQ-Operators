﻿using System;
using System.Linq;

namespace LINQ_Operators____Aggregation_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] skills = { "C#.NET", "MVC", "WCF", "SQL", "LINQ", "ASP.NET" };
            string result = skills.Aggregate((s1, s2) => s1 + ", " + s2);

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
