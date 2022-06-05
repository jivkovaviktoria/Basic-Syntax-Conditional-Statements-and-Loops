using System;

namespace SIgnOfIntegerNumbers
{
    class Program
    {
        static void SignOfNumber(int number)
        {
            string sign = "";
            if (number < 0) Console.WriteLine($"The number {number} is negative.");
            else if(number>0) Console.WriteLine($"The number {number} is positive."); 
            else if(number == 0) Console.WriteLine($"The number {number} is zero.");
            
        }
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            SignOfNumber(number);
        }
    }
}
