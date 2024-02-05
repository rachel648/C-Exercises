using System;

namespace RectangleCalculations
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Input the width and length
                Console.Write("Enter the width of the rectangle: ");
                double width = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the length of the rectangle: ");
                double length = Convert.ToDouble(Console.ReadLine());

                // Calculate area and perimeter
                double area = width * length;
                double perimeter = 2 * (width + length);

                // Display results
                Console.WriteLine($"Area of the rectangle: {area:F2}");
                Console.WriteLine($"Perimeter of the rectangle: {perimeter:F2}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter valid numeric values for width and length.");
            }
        }
    }
}
