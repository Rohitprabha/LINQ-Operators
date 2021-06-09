using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Operators__Join_3
{
    class Program
    {
        class DepartmentClass
        {
            public int DepartmentId { get; set; }
            public string Name { get; set; }
        }

        class EmployeeClass
        {
            public int EmployeeId { get; set; }
            public string EmployeeName { get; set; }
            public int DepartmentId { get; set; }
        }

        static void Main(string[] args)
        {

            List<DepartmentClass> departments = new List<DepartmentClass>();
            departments.Add(new DepartmentClass { DepartmentId = 1, Name = "Account" });
            departments.Add(new DepartmentClass { DepartmentId = 2, Name = "Sales" });
            departments.Add(new DepartmentClass { DepartmentId = 3, Name = "Marketing" });

            List<EmployeeClass> employees = new List<EmployeeClass>();
            employees.Add(new EmployeeClass { DepartmentId = 1, EmployeeId = 1, EmployeeName = "William" });
            employees.Add(new EmployeeClass { DepartmentId = 2, EmployeeId = 2, EmployeeName = "Miley" });
            employees.Add(new EmployeeClass { EmployeeId = 3, EmployeeName = "Benjamin" });


            var list = (from e in employees
                        join d in departments on e.DepartmentId equals d.DepartmentId into eGroup
                        from d in eGroup.DefaultIfEmpty()
                        select new
                        {
                            EmployeeName = e.EmployeeName,
                            DepartmentName = d == null ? "No Department" : d.Name
                        });

            foreach (var e in list)
            {
                Console.WriteLine("Employee Name = {0} , Department Name = {1}", e.EmployeeName, e.DepartmentName);
            }

            Console.ReadKey();
        }
    }
}
