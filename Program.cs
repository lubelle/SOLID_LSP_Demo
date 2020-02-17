using SOLID_LSP_DEMO.Abstract;
using SOLID_LSP_DEMO.Implementation;
using SOLID_LSP_DEMO.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_LSP_DEMO
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employeeList = new List<Employee>();
            employeeList.Add(new PermanentEmployee(101, "James"));
            employeeList.Add(new TemporaryEmployee(105, "Mod"));
            //employeeList.Add(new ContractEmployee(120, "Erin"));

            foreach (var employee in employeeList)
            {
                Console.WriteLine(string.Format("Employee {0} Bonus: {1} Minimum Salary: {2}",
                    employee.ToString(),
                    employee.CalculateBonus(10000),
                    employee.GetMinimumSalary()));
            }

            Console.ReadLine();


            List<IEmployee> employees = new List<IEmployee>();
            employees.Add(new PermanentEmployee(101, "James"));
            employees.Add(new TemporaryEmployee(105, "Mod"));
            employees.Add(new ContractEmployee(120, "Erin"));

            foreach (var employee in employees)
            {
                Console.WriteLine(string.Format("Employee {0} Minimum Salary: {1}", 
                    employee.ToString(),
                    employee.GetMinimumSalary()));
            }

            Console.ReadLine();
        }
    }
}
