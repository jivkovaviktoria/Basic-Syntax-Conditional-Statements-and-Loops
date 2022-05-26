using System;
using System.Linq;

namespace EvenAndOddSubtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sumEven = 0;
            int sumOdd = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];

                if (currentNumber % 2 == 0)
                {
                    sumEven += currentNumber;
                }
                else
                {
                    sumOdd += currentNumber;
                }
            }

            int result = 0;

            if (sumEven > sumOdd || sumOdd != 0)
            {
                result = sumEven - sumOdd;
            }
            else if (sumOdd >= sumEven || sumEven != 0)
            {
                result = sumOdd - sumEven;
            }
            else if (sumEven == 0)
            {
                result = sumEven - sumOdd;
            }
            else if (sumOdd == 0)
            {
                result = sumOdd - sumEven;
            }

            Console.WriteLine(result);

        }
    }
}
