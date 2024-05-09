using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompting the user to enter a number
        Console.WriteLine("Enter a number:");
        double number = double.Parse(Console.ReadLine());

        // Checking if the number is negative, positive, or zero
        if (number < 0)
        {
            Console.WriteLine("NEGATIVE");
        }
        else if (number > 0)
        {
            Console.WriteLine("POSITIVE");
        }
        else
        {
            Console.WriteLine("ZERO");
        }
    }
}
