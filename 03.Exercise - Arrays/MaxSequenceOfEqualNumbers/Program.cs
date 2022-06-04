using System;
using System.Linq;

namespace MaxSequenceOfEqualNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int maxSequenceElement = 0, maxSequenceLength = 0;
            int sequenceElement = numbers[0];
            int currentSequenceLength = 1;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == sequenceElement) currentSequenceLength++;
                else
                {
                    if (currentSequenceLength > maxSequenceLength)
                    {
                        maxSequenceElement = sequenceElement;
                        maxSequenceLength = currentSequenceLength;
                    }

                    sequenceElement = numbers[i];
                    currentSequenceLength = 1;
                }
            }

            if (currentSequenceLength > maxSequenceLength)
            {
                maxSequenceElement = sequenceElement;
                maxSequenceLength = currentSequenceLength;
            }

            for (int i = 0; i < maxSequenceLength; i++)
                Console.Write($"{maxSequenceElement} ");
        }
    }
}
