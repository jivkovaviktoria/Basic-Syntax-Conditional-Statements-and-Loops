using System;

namespace SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(smallestNum(firstNumber, secondNumber, thirdNumber));
        }
        static int smallestNum(int first, int second, int third)
        {
            int smallest = first;
            if (second<smallest)
                smallest = second;
            if (third < smallest)
                smallest = third;

            return smallest;
        }

            
    }
}
