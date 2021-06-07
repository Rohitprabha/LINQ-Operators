using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Operators____Conversion_3
{
    class Employee
    {
        public int Id
        { get; set; }
        public string Name
        { get; set; }
        public double Salary
        { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employeeList = new List<Employee>()
        {
            new Employee()
            {
                Id = 1, Name = "Sara", Salary = 41000
            },
            new Employee()
            {
                Id = 2, Name = "Sam", Salary = 11000
            },
            new Employee()
            {
                Id = 3, Name = "Aiden", Salary = 21000
            }
        };

            Dictionary<int, Employee> employeeDic = employeeList.ToDictionary(x => x.Id, y => y);
            foreach (KeyValuePair<int, Employee> employee in employeeDic)
            {
                Console.Write(employee.Key+ " ");
                Console.WriteLine(employee.Value.Name);
            }
        }
    }
}
