using System;
using System.Linq;

namespace ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] extract = Console.ReadLine().Split(':', '\\').ToArray();
            string[] file = extract.Last().Split('.').ToArray();

            string fileName = file[0];
            string extension = file[1];

            Console.WriteLine($"File name: {fileName}\nFile extension: {extension}");
        }
    }
}
