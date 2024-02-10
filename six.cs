using System;

class Program
{
    static void Main(string[] args)
    {
        // Accepting input for two numbers
        Console.WriteLine("Enter the first number:");
        double number1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        double number2 = double.Parse(Console.ReadLine());

        // Checking if the smaller number is zero
        if (number2 == 0)
        {
            Console.WriteLine("Error: Cannot divide by zero");
        }
        else
        {
            // Dividing the bigger number by the smaller number
            double result;
            if (number1 > number2)
            {
                result = number1 / number2;
            }
            else
            {
                result = number2 / number1;
            }
            
            // Displaying the result
            Console.WriteLine("Result: " + result);
        }
    }
}
