using System;

public class NumberComputation
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number:");
        double number1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        double number2 = double.Parse(Console.ReadLine());

        double result;

        if (number1 > number2)
        {
            result = number1 - number2;
            Console.WriteLine($"Result: {result}");
        }
        else if (number2 > number1)
        {
            result = number1 / number2;
            Console.WriteLine($"Result: {result}");
        }
        else
        {
            result = number1 + number2;
            Console.WriteLine($"Result: {result}");
        }
    }
}
