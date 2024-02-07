using System;

namespace KilometersToMeters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input the distance in kilometers: ");
            double kilometers = double.Parse(Console.ReadLine());

            //  kilometers to meters
            double meters = kilometers * 1000;

            Console.WriteLine($"{kilometers} kilometers = {meters} meters.");
        }
    }
}
