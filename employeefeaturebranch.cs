using System;
using System.Collections.Generic;

namespace CompanyApp.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }
        public DateTime DateOfJoining { get; set; }

        public Employee(int id, string name, string department, decimal salary, DateTime dateOfJoining)
        {
            Id = id;
            Name = name;
            Department = department;
            Salary = salary;
            DateOfJoining = dateOfJoining;
        }

        public void DisplayEmployee()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Department: {Department}");
            Console.WriteLine($"Salary: {Salary}");
            Console.WriteLine($"Date Of Joining: {DateOfJoining:dd-MM-yyyy}");
            Console.WriteLine("---------------------------");
        }
    }

    class Employees
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee(101, "Ravi Kumar", "IT", 60000, new DateTime(2022, 5, 10)),
                new Employee(102, "Anita Sharma", "HR", 50000, new DateTime(2021, 3, 15)),
                new Employee(103, "Suresh Reddy", "Finance", 70000, new DateTime(2020, 8, 20))
            };

            foreach (var emp in employees)
            {
                emp.DisplayEmployee();
            }

            Console.ReadLine();
        }
    }
}
