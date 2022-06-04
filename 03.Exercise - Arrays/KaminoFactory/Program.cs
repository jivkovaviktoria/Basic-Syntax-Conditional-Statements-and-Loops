using System;
using System.Linq;

namespace KaminoFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            int globalMaxSequenceStart = -1, globalMaxSequenceCount = -1, globalMaxSum = -1, globalMaxIndex = -1;
            int[] globalMaxSequence = new int[length];
            int index = 1;
            while (command != "Clone them!")
            {
                int[] elements = command.Split('!', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                int sum = 0;
                int maxSequenceStart = -1, maxSequenceCount = -1;
                int sequenceStart = -1, sequenceCount = 0;
                for (int i = 0; i < elements.Length; i++)
                {
                    sum += elements[i];
                    if (elements[i] == 1)
                    {
                        if (sequenceCount == 0) sequenceStart = i;
                        sequenceCount++;
                    }
                    else if (elements[i] == 0 && sequenceCount > 0)
                    {
                        if (sequenceCount > maxSequenceCount)
                        {
                            maxSequenceStart = sequenceStart;
                            maxSequenceCount = sequenceCount;
                        }

                        sequenceCount = 0;
                    }
                }
                if (sequenceCount > maxSequenceCount)
                {
                    maxSequenceStart = sequenceStart;
                    maxSequenceCount = sequenceCount;
                }

                if (maxSequenceCount > globalMaxSequenceCount
                    || (maxSequenceCount == globalMaxSequenceCount && maxSequenceStart < globalMaxSequenceStart)
                    || (maxSequenceCount == globalMaxSequenceCount && maxSequenceStart == globalMaxSequenceStart && sum > globalMaxSum))
                {
                    globalMaxSequenceStart = maxSequenceStart;
                    globalMaxSequenceCount = maxSequenceCount;
                    globalMaxSum = sum;
                    globalMaxIndex = index;
                    globalMaxSequence = elements;
                }

                command = Console.ReadLine();
                index++;
            }

            Console.WriteLine($"Best DNA sample {globalMaxIndex} with sum: {globalMaxSum}.");
            Console.WriteLine(string.Join(" ", globalMaxSequence));
        }
    }
}
