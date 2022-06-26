using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<char> text = Console.ReadLine().ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                int index = GetIndex(numbers[i]);

                if(index>text.Count-1)
                {
                    while (index > text.Count)
                        index -= text.Count;
                }

                Console.Write(text[index]);
                text.RemoveAt(index);
            }
        }

        static int GetIndex(int num)
        {
            int index = 0;
            while (num!=0)
            {
                index += num % 10;
                num /= 10;
            }

            return index;
        }
    }
}
