using System;
using System.Text;

namespace ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            while (text!="end")
            {
                Console.WriteLine($"{text} = {Reverse(text)}");
                text = Console.ReadLine();
            }
        }
        static string Reverse(string text)
        {
            string reversedText = "";

            for (int i = text.Length-1; i >= 0; i--)
                reversedText += text[i];

            return reversedText;
        }
    }
    
}
