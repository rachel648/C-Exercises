using System;

class Figures
{
    static void Main(string[] args)
    {
        int figure;
        int dimension1;
        int dimension2;
        int dimension3;

        Console.WriteLine(" 1) Rectangle");
        Console.WriteLine(" 2) Circle");
        Console.WriteLine(" 3) Right-angled triangle");

        Console.WriteLine("Select a figure by number");
        figure = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter dimension1");
        dimension1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter dimension2");
        dimension2 = Convert.ToInt32(Console.ReadLine());

        if (figure == 1)
        {
            Console.WriteLine("The type of figure is a rectangle");
            Console.WriteLine("Area: " + (dimension1 * dimension2));
            Console.WriteLine("Perimeter: " + (2 * (dimension1 + dimension2)));
        }
        else if (figure == 2)
        {
            Console.WriteLine("The type of figure is a circle");
            Console.WriteLine("Area: " + (Math.PI * dimension1 * dimension1));
            Console.WriteLine("Perimeter: " + (2 * Math.PI * dimension1));
        }
        else if (figure == 3)
        {
            Console.WriteLine("The type of figure is a right-angled triangle");
            Console.WriteLine("Enter dimension3");
            dimension3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Area: " + 0.5 * dimension1 * dimension2);
            Console.WriteLine("Perimeter: " + (dimension1 + dimension2 + dimension3));
        }
        else
        {
            Console.WriteLine("Invalid figure number");
        }
    }
}
