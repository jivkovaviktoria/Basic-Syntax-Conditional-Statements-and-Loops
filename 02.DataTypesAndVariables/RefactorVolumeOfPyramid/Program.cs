using System;

namespace RefactorVolumeOfPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Length: ");

            double length = double.Parse(Console.ReadLine());

            Console.WriteLine("Width: ");

            double width = double.Parse(Console.ReadLine());

            Console.WriteLine("Heigth: ");

            double heigth = double.Parse(Console.ReadLine());

            double Volume = (length + width + heigth) / 3;

            Console.WriteLine($"Pyramid Volume: {Volume:f2}");
        }
    }
}
