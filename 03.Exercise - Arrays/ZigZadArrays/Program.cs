using System;
using System.Linq;

namespace ZigZadArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] firstArr = new int[n];
            int[] secondArr = new int[n];


            for (int i = 0; i < n; i++)
            {
                int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (i % 2 == 0)
                {
                    firstArr[i] = elements[0];
                    secondArr[i] = elements[1];
                }
                else
                { 
                    firstArr[i] = elements[1];
                    secondArr[i] = elements[0];
                }
            }

            Console.WriteLine(string.Join(" ", firstArr));
            Console.WriteLine(string.Join(" ", secondArr));
        }
    }
}
