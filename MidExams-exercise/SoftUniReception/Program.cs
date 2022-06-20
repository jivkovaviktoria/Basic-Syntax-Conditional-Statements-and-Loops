using System;

namespace SoftUniReception
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEmployee = int.Parse(Console.ReadLine());
            int secondEmployee = int.Parse(Console.ReadLine());
            int thirdEmployee = int.Parse(Console.ReadLine());

            int students = int.Parse(Console.ReadLine());

            int studentsPerHour = firstEmployee + secondEmployee + thirdEmployee;
            int studentsLeft = students;
            int result = 0;
            int countHours = 1;
            while (studentsLeft > 0)
            {
                if(countHours % 4 == 0)
                {
                    result++;
                    countHours++;
                    continue;
                }

                studentsLeft -= studentsPerHour;
                result++;
                countHours++;
            }

            Console.WriteLine($"Time needed: {result}h.");
        }
    }
}
