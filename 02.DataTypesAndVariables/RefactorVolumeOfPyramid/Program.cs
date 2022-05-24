using System;

namespace RefactorVolumeOfPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            double dul, sh, V = 0;

            Console.WriteLine("Length: ");

            dul = double.Parse(Console.ReadLine());

            Console.WriteLine("Width: ");

            sh = double.Parse(Console.ReadLine());

            Console.WriteLine("Heigth: ");

            V = double.Parse(Console.ReadLine());

            V = (dul + sh + V) / 3;

            Console.WriteLine($"Pyramid Volume: {V:f2}");
        }
    }
}
