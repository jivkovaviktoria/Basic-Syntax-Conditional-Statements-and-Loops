using System;

namespace DecryptingMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            string word = "";
            for (int i = 0; i < n; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                word += (char)(letter + key);
            }
            Console.WriteLine(word);
        }
    }
}
