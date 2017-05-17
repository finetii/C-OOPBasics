using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4CompanyRoster
{
    public class CompanyRoster
    {
        public class Employee
        {
            public string name;
            public decimal salary;
            public string position;
            public string department;
            public string email;
            public int age;
            

            public Employee(string name,decimal salary, string position, string department)
            {
                this.name = name;
                this.salary = salary;
                this.position = position;
                this.department = department;
                this.email = "n/a";
                this.age = -1;
            }
        }
        public static void Main()
        {
            int numberOfEmployees = int.Parse(Console.ReadLine());

            var employees = new List<Employee>();

            for (int i = 0; i < numberOfEmployees; i++)
            {
                string[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                Employee employee = new Employee(input[0], decimal.Parse(input[1]), input[2], input[3]);
                
                if (input.Length > 4)
                {
                    string emailOrAge = input[4];
                    if (emailOrAge.Contains("@"))
                    {
                        employee.email = emailOrAge;
                    }
                    else
                        employee.age = int.Parse(emailOrAge);

                    if (input.Length > 5)
                    {
                        employee.age = int.Parse(input[5]);
                    }
                }                

                employees.Add(employee);
            }

            var result = employees.GroupBy(e => e.department).Select(e => e);
            Dictionary<string, decimal> avg = new Dictionary<string, decimal>();
            foreach(var item in result)
            {
                avg[item.Key] = item.Average(a => a.salary);
            }
            var r = avg.OrderByDescending(a => a.Value).FirstOrDefault();

            /*var result = employees.GroupBy(e => e.department).Select(e => new {
                Department = e.Key,
                AverageSalary = e.Average(emp => emp.salary),
                Employees = e.OrderByDescending(emp => emp.salary)
            })//.FirstOrDefault();//*/

            Console.WriteLine($"Highest Average Salary: {r.Key}" );
            foreach (var e in employees.Where(e => e.department == r.Key).OrderByDescending(e => e.salary))
            {                
                Console.WriteLine($"{e.name} {e.salary:F2} {e.email} {e.age}");
            }
        }
    }
}
