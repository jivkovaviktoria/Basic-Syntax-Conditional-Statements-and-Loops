using System;

namespace FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            FactorialDivision(firstNum, secondNum);
        }

        static void FactorialDivision(int firstNum, int secondNum)
        {
            long firstFactorial = 1;
            long secondFactorial = 1;

            for (int i = 2; i <= firstNum; i++)
                firstFactorial *= i;

            for (int i = 2; i <= secondNum; i++)
                secondFactorial *= i;

            double result = firstFactorial*1.0/ secondFactorial;
            Console.WriteLine($"{result:f2}");
        }    
    }
}
