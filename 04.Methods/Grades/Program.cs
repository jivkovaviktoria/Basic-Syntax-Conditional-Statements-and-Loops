using System;

namespace Grades
{
    class Program
    {
       
        static void Grade(double grade)
        {
            if (grade > 1.99 && grade <=  2.99) Console.WriteLine("Fail");
            if (grade > 2.99 && grade <= 3.49) Console.WriteLine("Poor");
            if (grade > 3.49 && grade <= 4.49) Console.WriteLine("Good");
            if (grade > 4.49 && grade <= 5.49) Console.WriteLine("Very good");
            if (grade > 5.49 && grade <= 6.00) Console.WriteLine("Excellent");
        }
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            Grade(grade);
        }
    }
}
