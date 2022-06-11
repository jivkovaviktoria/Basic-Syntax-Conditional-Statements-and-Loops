using System;

namespace AddAndSubtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int result = Sum(firstNum, secondNum);
            int total = Subtract(thirdNum, result);
            Console.WriteLine(total);
        }
        static int Sum(int firstNum, int secondNum)
        {
            return firstNum + secondNum;
        }
        static int Subtract(int thirdNum, int result)
        {
            return result - thirdNum;
        }
    }
}
