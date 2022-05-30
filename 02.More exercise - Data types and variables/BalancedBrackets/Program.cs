using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        bool isBalanced = true;
        var stack = new Stack<char>();
        var openedCount = 0;

        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();

            foreach (char character in input)
            {
                if (character == '(')
                {
                    openedCount++;
                    if (openedCount == 2)
                    {
                        isBalanced = false;
                    }
                    stack.Push(character);
                }
                else if (character == ')')
                {
                    openedCount = 0;
                    if (stack.Count() == 0)
                        isBalanced = false;

                    else if (stack.Pop() != '(')
                        isBalanced = false;
                }
            }
        }

        if (stack.Count() != 0)
        {
            isBalanced = false;
        }

        Console.WriteLine(isBalanced ? "BALANCED" : "UNBALANCED");
    }
}
