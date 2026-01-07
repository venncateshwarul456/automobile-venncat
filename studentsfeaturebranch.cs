using System;
using System.Collections.Generic;

namespace SchoolApp.Models
{
    public class Student
    {
        public int RollNumber { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public double Marks { get; set; }

        public Student(int rollNumber, string name, string studentClass, double marks)
        {
            RollNumber = rollNumber;
            Name = name;
            Class = studentClass;
            Marks = marks;
        }

        public string GetResult()
        {
            return Marks >= 40 ? "Pass" : "Fail";
        }

        public void DisplayStudent()
        {
            Console.WriteLine($"Roll No: {RollNumber}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Class: {Class}");
            Console.WriteLine($"Marks: {Marks}");
            Console.WriteLine($"Result: {GetResult()}");
            Console.WriteLine("---------------------------");
        }
    }

    class Students
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student(1, "Amit", "10th", 78.5),
                new Student(2, "Sneha", "10th", 35.0),
                new Student(3, "Rahul", "9th", 62.0)
            };

            foreach (var student in students)
            {
                student.DisplayStudent();
            }

            Console.ReadLine();
        }
    }
}
