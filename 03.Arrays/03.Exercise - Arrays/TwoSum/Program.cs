using System;
using System.Collections.Generic;
using System.Linq;

namespace TwoSum
{
    internal class Program
    {
        static void Main()
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int targetSum = int.Parse(Console.ReadLine());

            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int currentNumber = nums[i];
                if (dict.ContainsKey(currentNumber))
                {
                    Console.WriteLine(dict[currentNumber]);
                    Console.WriteLine(i);
                    break;
                }

                dict[targetSum - currentNumber] = i;
            }
        }
    }
}
