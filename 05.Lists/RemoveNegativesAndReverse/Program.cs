﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            numbers.RemoveAll(number => number<0);
            numbers.Reverse();

            if (numbers.Count > 0)
            {
                Console.WriteLine(string.Join(" ", numbers));
                return;
            }

            Console.WriteLine("empty");

            
            
        }
    }
}
