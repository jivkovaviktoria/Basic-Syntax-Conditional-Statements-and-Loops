using System;
using System.Text;

namespace RepeatStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split();
            StringBuilder sb = new StringBuilder();

            foreach (var word in text)
            {
                for (int i = 0; i < word.Length; i++)
                    sb.Append(word);
            }

            Console.WriteLine(sb);
        }
    }
}
