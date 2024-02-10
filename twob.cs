using System;

public class BeerBrands
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter two numbers separated by a space:");
        string input = Console.ReadLine();
        string[] tokens = input.Split();

        if (tokens.Length != 2)
        {
            Console.WriteLine("Invalid input. Please enter two numbers:");
              return;
        }

        double number, number1;
        if (!double.TryParse(tokens[0], out number) || !double.TryParse(tokens[1], out number1))
        {
            Console.WriteLine("Invalid input. Please enter valid numbers.");
            return;
        }

        Console.WriteLine("Enter an operator: ");
        string @operators = Console.ReadLine();

        switch (@operators)
        {
            case "+":
                Console.WriteLine(number + number1);
                break;
            case "-":
                Console.WriteLine(number - number1);
                break;
            case "*":
                Console.WriteLine(number * number1);
                break;
            case "%":
                Console.WriteLine(number % number1);
                break;
            case "/":
                Console.WriteLine(number / number1); // Dividing the two numbers, not the same number by itself
                break;
            default:
                Console.WriteLine("invalid input");
                break;
        }
    }
}
