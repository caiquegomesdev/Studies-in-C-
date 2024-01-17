using System;
using System.Collections.Generic;

namespace ExecFixacaoListas
{
    class Program
    {
        static void Main()
        {
            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> employees = new List<Employee>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i}:");
                Employee employee = ReadEmployeeData(employees);
                employees.Add(employee);
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int searchId = int.Parse(Console.ReadLine());

            Employee selectedEmployee = employees.Find(e => e.Id == searchId);

            if (selectedEmployee != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine());
                selectedEmployee.IncreaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("Employee not found. Operation aborted.");
            }

            Console.WriteLine("Updated list of employees:");
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
            }
        }

        static Employee ReadEmployeeData(List<Employee> existingEmployees)
        {
            int id;
            string name;
            double salary;

            do
            {
                Console.Write("Id: ");
                id = int.Parse(Console.ReadLine());
                if (existingEmployees.Exists(e => e.Id == id))
                {
                    Console.WriteLine("An employee with this ID already exists. Please choose a different ID.");
                }
            } while (existingEmployees.Exists(e => e.Id == id));

            Console.Write("Name: ");
            name = Console.ReadLine();
            Console.Write("Salary: ");
            salary = double.Parse(Console.ReadLine());

            return new Employee(id, name, salary);
        }
    }

    class Employee
    {
        public int Id { get; }
        public string Name { get; set; }
        private double _salary;

        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            _salary = salary;
        }

        public void IncreaseSalary(double percentage)
        {
            _salary += _salary * (percentage / 100);
        }

        public override string ToString()
        {
            return $"{Id}, {Name}, {_salary:F2}";
        }
    }

}