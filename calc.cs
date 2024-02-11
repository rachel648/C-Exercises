using System;

class Calculator
{
    static void Main(string[] args)
    {
        double num1, num2, result;
        char operation;

        Console.WriteLine("Enter the first number:");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter an operation (+, -, *, /):");
        operation = Convert.ToChar(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        num2 = Convert.ToDouble(Console.ReadLine());

        switch (operation)
        {
            case '+':
                result = num1 + num2;
                Console.WriteLine("Result: " + result);
                break;
            case '-':
                result = num1 - num2;
                Console.WriteLine("Result: " + result);
                break;
            case '*':
                result = num1 * num2;
                Console.WriteLine("Result: " + result);
                break;
            case '/':
                if (num2 != 0)
                {
                    result = num1 / num2;
                    Console.WriteLine("Result: " + result);
                }
                else
                {
                    Console.WriteLine("Error: Division by zero!");
                }
                break;
            default:
                Console.WriteLine("Invalid operation!");
                break;
        }

        Console.ReadLine(); // Keeps the console window open
    }
}
