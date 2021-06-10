using System;
using System.Linq;

namespace LINQ_Operators___Ordering_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Method Syntax
            var MS = Student.GetAllStudents()
                              .OrderBy(x => x.FirstName)
                              .ThenBy(y => y.LastName)
                              .ToList();

            foreach (var student in MS)
            {
                Console.WriteLine("First Name :" + student.FirstName + ", Last Name : " + student.LastName);
            }
            Console.WriteLine();
            Console.WriteLine("ThenByDescending");
            var MS2 = Student.GetAllStudents()
                              .OrderBy(x => x.FirstName)
                              .ThenByDescending(y => y.LastName)
                              .ToList();
            foreach (var student in MS2)
            {
                Console.WriteLine("First Name :" + student.FirstName + ", Last Name : " + student.LastName);
            }
            Console.ReadKey();
        }
    }
}
