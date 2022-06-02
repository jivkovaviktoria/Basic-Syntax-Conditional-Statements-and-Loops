using System;
using System.Linq;

namespace ArrayModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] arguments = command.Split();

                if (arguments[0] == "swap")
                {
                    int index1 = int.Parse(arguments[1]);
                    int index2 = int.Parse(arguments[2]);

                    int temp = numbers[index1];
                    numbers[index1] = numbers[index2];
                    numbers[index2] = temp;
                }
                else if (arguments[0] == "multiply")
                {
                    int index1 = int.Parse(arguments[1]);
                    int index2 = int.Parse(arguments[2]);

                    int result = numbers[index1] * numbers[index2];
                    numbers[index1] = result;
                }
                else if (arguments[0] == "decrease")
                {
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        numbers[i] -= 1;
                    }
                }
                command = Console.ReadLine();

            }


            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
