using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Operators__Join_4
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


            var list = (from d in departments
                        join e in employees on d.DepartmentId equals e.DepartmentId into eGroup
                        from e in eGroup.DefaultIfEmpty()
                        select new
                        {
                            EmployeeName = e == null ? "No Employee" : e.EmployeeName,
                            DepartmentName = d.Name
                        });

            foreach (var e in list)
            {
                Console.WriteLine("Department Name = {1}, Employee Name = {0}", e.EmployeeName, e.DepartmentName);
            }

            Console.ReadKey();
        }
    }
}
