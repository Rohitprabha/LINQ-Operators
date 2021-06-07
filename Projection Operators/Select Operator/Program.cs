using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Operators___Projection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select all the data from the data source");

            Console.WriteLine("Using Query Syntax");
            List<Employee> basicQuery = (from emp in Employee.GetEmployees()                    //Using Query Syntax
                                         select emp).ToList();
            foreach (Employee emp in basicQuery)
            {
                Console.WriteLine($"ID : {emp.ID} Name : {emp.FirstName} {emp.LastName} Salary : {emp.Salary}");
            }

            Console.WriteLine("Using Method Syntax");
            IEnumerable<Employee> basicMethod = Employee.GetEmployees().ToList();               //Using Method Syntax
            foreach (Employee emp in basicMethod)
            {
                Console.WriteLine($"ID : {emp.ID} Name : {emp.FirstName} {emp.LastName} Salary : {emp.Salary}");
            }
            Console.WriteLine();

            Console.WriteLine("select a single property using Select Operator");

            Console.WriteLine("Using Query Syntax");
            List<int> basicPropQuery = (from emp in Employee.GetEmployees()                     //Using Query Syntax
                                        select emp.ID).ToList();
            foreach (var id in basicPropQuery)
            {
                Console.WriteLine($"ID : {id}");
            }

            Console.WriteLine("Using Method Syntax");
            IEnumerable<int> basicPropMethod = Employee.GetEmployees()                          //Using Method Syntax
                                               .Select(emp => emp.ID);

            foreach (var id in basicPropMethod)
            {
                Console.WriteLine($"ID : {id}");
            }
            Console.WriteLine();

            Console.WriteLine("select a multiple properties using Select Operator");

            Console.WriteLine("Query Syntax");
            var selectQuery = (from emp in Employee.GetEmployees()
                               select new
                               {
                                   FullName = emp.FirstName + " " + emp.LastName,
                                   AnnualSalary = emp.Salary * 2
                               });
            foreach (var emp in selectQuery)
            {
                Console.WriteLine($" Name : {emp.FullName} Salary : {emp.AnnualSalary} ");
            }

            Console.WriteLine("Method Syntax");
            var selectMethod = Employee.GetEmployees().
                                          Select(emp => new
                                          {
                                              FullName = emp.FirstName + " " + emp.LastName,
                                              AnnualSalary = emp.Salary * 2
                                          }).ToList();
            foreach (var emp in selectMethod)
            {
                Console.WriteLine($" Name : {emp.FullName} Salary : {emp.AnnualSalary} ");
            }
            Console.WriteLine();

            Console.WriteLine("select data with index value");

            Console.WriteLine("using Query Syntax");
            var query = (from emp in Employee.GetEmployees().Select((value, index) => new { value, index })     //Query Syntax
                         select new
                         {
                             IndexPosition = emp.index,
                             FullName = emp.value.FirstName + " " + emp.value.LastName,
                             Salary = emp.value.Salary
                         }).ToList();
            foreach (var emp in query)
            {
                Console.WriteLine($" Position {emp.IndexPosition} Name : {emp.FullName} Salary : {emp.Salary} ");
            }

            Console.WriteLine("using Method Syntax");
            var selectMethod1 = Employee.GetEmployees().                                                            //Method Syntax
                                          Select((emp, index) => new
                                          {
                                              IndexPosition = index,
                                              FullName = emp.FirstName + " " + emp.LastName,
                                              Salary = emp.Salary
                                          });

            foreach (var emp in selectMethod1)
            {
                Console.WriteLine($" Position {emp.IndexPosition} Name : {emp.FullName} Salary : {emp.Salary} ");
            }

            Console.ReadKey();
        }
    }
}
