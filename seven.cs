using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double num2 =  Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nBefore swapping:");
        Console.WriteLine("Number 1:" + num1 );
        Console.WriteLine("Number 2:" +num2);

        // Call the swapNumbers function to swap the values
        swapNumbers(ref num1, ref num2);

        Console.WriteLine("\nAfter swapping:");
        Console.WriteLine("Number 1:" + num1);
        Console.WriteLine("Number 2:" + num2);
    }

    static void swapNumbers(ref double a, ref double b)
    {
        double temp = a;
        a = b;
        b = temp;
    }
}
