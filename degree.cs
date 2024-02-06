using System;

namespace CelsiusToFahrenheitConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter temperature in Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());
            double fahrenheit = ((celsius * 9) / 5) + 32;
            Console.WriteLine("The converted Fahrenheit temperature is: " + fahrenheit );
            Console.ReadLine();
        }
    }
}
