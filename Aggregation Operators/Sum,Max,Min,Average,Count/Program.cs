using System;
using System.Linq;

namespace LINQ_Operators____Aggregation_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intNumbers = new int[] { 10, 30, 50, 40, 60, 20, 70, 90, 80, 100 };
            int MSTotal = intNumbers.Sum();
            Console.WriteLine("Sum = " + MSTotal);

            int MSLergestNumber = intNumbers.Max();
            Console.WriteLine("Largest Number = " + MSLergestNumber);

            int MSLowestNumber = intNumbers.Min();
            Console.WriteLine("Lowest Number = " + MSLowestNumber);

            var MSAverageValue = intNumbers.Average();
            Console.WriteLine("Average Value = " + MSAverageValue);

            int MSCount = intNumbers.Count();
            Console.WriteLine("No of Elements = " + MSCount);
            Console.ReadKey();
        }
    }
}
