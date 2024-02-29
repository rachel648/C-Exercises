using System;

class Program
{
    static void Main(string[] args)
    {
        int num1, num2;

        // Get input from the user
        Console.Write("Enter first number: ");
        num1 = int.Parse(Console.ReadLine()!);
        Console.Write("Enter second number: ");
        num2 = int.Parse(Console.ReadLine()!);

        // Call the function to calculate the sum (passing by reference)
        int total = Sum(ref num1, ref num2);

        // Display the sum using an appropriate format specifier
        Console.WriteLine($"The sum of {num1} and {num2} is {total}");
    }

    static int Sum(ref int num1, ref int num2)
    {
        return num1 + num2;
    }
}
