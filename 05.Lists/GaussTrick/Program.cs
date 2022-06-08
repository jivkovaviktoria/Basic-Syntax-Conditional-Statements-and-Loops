using System;
using System.Linq;
using System.Collections.Generic;

namespace GaussTrick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            int halfLength = list.Count / 2;
            for (int i = 0; i < halfLength; i++)
            {
                list[i] = list[i] + list[list.Count - 1];
                list.RemoveAt(list.Count - 1);
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
