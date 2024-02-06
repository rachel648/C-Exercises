using System;

public class TriangleArea
{
    public static void Main()
    {
       
        Console.Write("Enter the width of the triangle: ");
        double width = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the height of the triangle: ");
        double height = Convert.ToDouble(Console.ReadLine());

      
        double area = 0.5 * width * height;

        Console.WriteLine("Area of the right-angled triangle: "+area);
    }
}
