using System;

namespace CentimetersToMetersConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the measurement in centimeters: ");
            double centimeters = double.Parse(Console.ReadLine());

            // Convert centimeters to meters
            double meters = centimeters / 100;

            Console.WriteLine($"{centimeters} cm = {meters} meters.");
        }
    }
}
