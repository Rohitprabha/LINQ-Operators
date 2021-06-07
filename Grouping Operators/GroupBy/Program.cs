using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Operators___Grouping_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var GroupByMS = Student.GetStudents().GroupBy(s => s.Barnch);
            //Using Query Syntax
            IEnumerable<IGrouping<string, Student>> GroupByQS = (from std in Student.GetStudents()
                                                                 group std by std.Barnch);
            //It will iterate through each groups
            foreach (var group in GroupByMS)
            {
                Console.WriteLine(group.Key + " : " + group.Count());
                //Iterate through each student of a group
                foreach (var student in group)
                {
                    Console.WriteLine("  Name :" + student.Name + ", Age: " + student.Age + ", Gender :" + student.Gender);
                }
            }
            Console.Read();
        }
    }
}
