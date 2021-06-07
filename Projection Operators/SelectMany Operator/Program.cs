using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Operators___Projection_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> MethodSyntax = Student.GetStudents().SelectMany(std => std.Programming).ToList();      //Using Method Syntax

            IEnumerable<string> QuerySyntax = from std in Student.GetStudents()                                 //Using Query Syntax
                                              from program in std.Programming
                                              select program;
            foreach (string program in MethodSyntax)
            {
                Console.WriteLine(program);
            }
            Console.WriteLine();

            Console.WriteLine("Only the distinct program names(without the duplicate):");
            List<string> MethodSyntax1 = Student.GetStudents()                                      //Using Method Syntax
                                        .SelectMany(std => std.Programming)
                                        .Distinct()
                                        .ToList();

            IEnumerable<string> QuerySyntax2 = (from std in Student.GetStudents()                   //Using Query Syntax
                                                from program in std.Programming
                                                select program).Distinct().ToList();
            foreach (string program in QuerySyntax2)
            {
                Console.WriteLine(program);
            }
            Console.WriteLine();

            Console.WriteLine("retrieve the student name along with the program language name");

            var MethodSyntax3 = Student.GetStudents()                                               //Using Method Syntax
                                        .SelectMany(std => std.Programming,
                                             (student, program) => new
                                             {
                                                 StudentName = student.Name,
                                                 ProgramName = program
                                             }
                                             )
                                        .ToList();

            var QuerySyntax3 = (from std in Student.GetStudents()                                   //Using Query Syntax
                                from program in std.Programming
                                select new
                                {
                                    StudentName = std.Name,
                                    ProgramName = program
                                }).ToList();
            //Printing the values
            foreach (var item in QuerySyntax3)
            {
                Console.WriteLine(item.StudentName + " => " + item.ProgramName);
            }

        }
    }
}
