using System;

namespace PascalTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            long[] previousRow = new long[0];
            for (int i = 0; i < n; i++)
            {
                long[] currentRow = new long[i + 1];
                currentRow[0] = 1;

                if (i >= 2)
                {
                    for (int j = 1; j < i; j++)
                        currentRow[j] = previousRow[j - 1] + previousRow[j];
                }

                if (i >= 1) currentRow[i] = 1;

                Console.WriteLine(string.Join(" ", currentRow));
                previousRow = currentRow;
            }
        }
    }
}
