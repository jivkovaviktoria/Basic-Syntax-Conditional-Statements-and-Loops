using System;
using System.Linq;
using System.Collections.Generic;

namespace CompanyRoster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<Employee> employees = new List<Employee>();
            Dictionary<string, List<double>> departments = new Dictionary<string, List<double>>();

            for (int i = 0; i < count; i++)
            {
                string[] tokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = tokens[0];
                double salary = double.Parse(tokens[1]);
                string department = tokens[2];

                Employee newEmployee = new Employee(name, salary, department);
                employees.Add(newEmployee);

                if (!departments.ContainsKey(department)) departments.Add(department, new List<double>());
                
                departments[department].Add(salary);
            }

            double maxAverage = 0;
            string maxAverageSalaryDep = "";
            foreach (var department in departments)
            {
                if (department.Value.Average() > maxAverage)
                {
                    maxAverage = department.Value.Average();
                    maxAverageSalaryDep = department.Key;
                }
            }

            employees = employees.OrderByDescending(x => x.Salary).ToList();

            Console.WriteLine($"Highest Average Salary: {maxAverageSalaryDep}");
            foreach (var employee in employees)
            {
                if (employee.Department == maxAverageSalaryDep) Console.WriteLine($"{employee.Name} {employee.Salary:f2}");
            }
        }
    }

    class Employee
    {
        public Employee(string name, double salary, string department)
        {
            Name = name;
            Salary = salary;
            Department = department;
        }
        public string Name { get; set; }

        public double Salary { get; set; }

        public string Department { get; set; }

    }
}