using System;

namespace Circle
{
    class Program
    {
        static void Main(string[] args)
        {
double PI=3.142;
            
                // Input the radius
                Console.Write("Enter the radius of the circle: ");
                double radius = Convert.ToDouble(Console.ReadLine());

                // Calculate area and circumference
                double area = PI*radius*radius;
                double circumference = PI*(radius+radius);

         // Display results
        // Console.WriteLine("Area of the circle: {0} . circumference of tecircle:{1}",area,circumference);

              Console.WriteLine("Area of the circle: "+ area);
             Console.WriteLine("Area of the circle: "+ circumference);
            
        }
    }
}
