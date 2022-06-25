using System;
using System.Collections.Generic;
using System.Linq;

namespace AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {


            string[] numbers = Console.ReadLine().Split('|').ToArray();

            List<string> result = new List<string>();


            for (int i = numbers.Length-1; i >= 0; i--)
            {
                string elements = numbers[i];
                string[] arr = elements.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < arr.Length; j++)
                {
                    result.Add(arr[j]);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
