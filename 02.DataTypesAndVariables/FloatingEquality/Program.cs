using System;

namespace FloatingEquality
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double esp = 0.000001;
            
            bool equal = Math.Abs(firstNumber - secondNumber)<esp;

            Console.WriteLine(equal);
        }
    }
}
