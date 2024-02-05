using System;

namespace CircleCalculations
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Input the radius
                Console.Write("Enter the radius of the circle: ");
                double radius = Convert.ToDouble(Console.ReadLine());

                // Calculate area and circumference
                double area = Math.PI * Math.Pow(radius, 2);
                double circumference = 2 * Math.PI * radius;

                // Display results
                Console.WriteLine($"Area of the circle: {area:F2}");
                Console.WriteLine($"Circumference of the circle: {circumference:F2}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid numeric value for the radius.");
            }
        }
    }
}
