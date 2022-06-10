using System;
using System.Linq;

namespace FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mainArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int k = mainArray.Length / 4;
            int[] foldedArray = new int[k * 2];

            for (int i = 0; i < foldedArray.Length / 2; i++)
                foldedArray[i] = mainArray[k - (i + 1)];

            int a = 0;
            for (int i = foldedArray.Length / 2; i < foldedArray.Length; i++)
            {
                a++;
                foldedArray[i] = mainArray[mainArray.Length - a];
            }

            int[] result = new int[foldedArray.Length];

            for (int i = 0; i < result.Length; i++)
                result[i] = foldedArray[i] + mainArray[i + k];

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
