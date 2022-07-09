using System;
using System.Text;

namespace TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] banWord = Console.ReadLine().Split(new char[] { ' ', ',', '.', '!', '*' }, StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();

            foreach (var word in banWord)
                text = text.Replace(word, new string('*', word.Length));

            Console.WriteLine(text);
        }


    }
}
