using System;

namespace CalculateSpeed
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the distance traveled in meters: ");
            double distanceMeters = double.Parse(Console.ReadLine());

            Console.Write("Input the time taken in minutes: ");
            double timeMinutes = double.Parse(Console.ReadLine());

            // minutes to hours
            double timeHours = timeMinutes / 60;

            // speed in meters per second
            double speedMetersPerSecond = distanceMeters / timeHours;

            //  speed to kilometers per hour
            double speedKilometersPerHour = speedMetersPerSecond * 3.6;

            Console.WriteLine($"Speed: {speedKilometersPerHour} km/h");
        }
    }
}
