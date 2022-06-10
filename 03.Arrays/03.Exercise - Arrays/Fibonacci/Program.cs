using System;

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] elements = new int[n];
            elements[0] = 1;

            if (n > 1)
                elements[1] = 1;

            for (int i = 2; i < elements.Length; i++)
            {
                elements[i] = elements[i - 1] + elements[i - 2];
            }
            Console.WriteLine(elements[n - 1]);
        }
    }
}
