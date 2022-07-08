using System;
using System.Collections.Generic;

namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] tokens = input.Split(" : ");
                string courseName = tokens[0];
                string student = tokens[1];

                if (!courses.ContainsKey(courseName))
                {
                    courses.Add(courseName, new List<string>());
                    courses[courseName].Add(student);
                }
                else
                    courses[courseName].Add(student);

                input = Console.ReadLine();
            }

            foreach (var course in courses)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");

                foreach (var item in course.Value)
                    Console.WriteLine($"-- {item}");
            }

        }
    }
}
