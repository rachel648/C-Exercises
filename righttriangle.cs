using System;

public class AreaOfTriangle
{
    public static void Main()
    {
        // Input the sides of the right-angled triangle
        Console.Write("Enter the width of the triangle: ");
        double width = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the height of the triangle: ");
        double height = Convert.ToDouble(Console.ReadLine());

        // Calculate the area (using the formula: Area = 0.5 * width * height)
        double area = 0.5 * width * height;

        Console.WriteLine($"Area of the right-angled triangle: {area:F2}");
    }
}
