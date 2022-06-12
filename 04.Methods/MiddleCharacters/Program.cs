using System;

namespace MiddleCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string result = MiddleCharacters(text);
            Console.WriteLine(result);
        }
        static string MiddleCharacters(string text)
        {
            int middle = text.Length/2;
            if (text.Length%2==0)
            {
                return $"{text[middle-1]}{text[middle]}";
            }
            else
            {
                return $"{text[middle]}";
            }
        }
    }
    

}
