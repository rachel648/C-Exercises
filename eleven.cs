using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        double number = Convert.ToDouble(Console.ReadLine());

        double square = Math.Pow(number, 2);
        double cube = Math.Pow(number, 3);
        double squareRoot = Math.Sqrt(number);
        double cubeRoot = Math.Pow(number, 1.0 / 3.0);

        Console.WriteLine($"Square: {square}");
        Console.WriteLine($"Cube: {cube}");
        Console.WriteLine($"Square Root: {squareRoot}");
        Console.WriteLine($"Cube Root: {cubeRoot}");
    }
}
