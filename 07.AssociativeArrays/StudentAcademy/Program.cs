using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> studentGrades = new Dictionary<string, double>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n * 2; i += 2)
            {
                string student = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!studentGrades.ContainsKey(student))
                    studentGrades.Add(student, grade);
                else
                    studentGrades[student] = (studentGrades[student] + grade) / 2;
            }

            foreach (var (student, grade) in studentGrades)
            {
                if (grade >= 4.50)
                    Console.WriteLine($"{student} -> {grade:f2}");
            }
        }
    }
}
