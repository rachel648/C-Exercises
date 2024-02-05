using System;

namespace NumberOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Input three numbers
                Console.Write("Enter the first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the third number: ");
                double num3 = Convert.ToDouble(Console.ReadLine());

                // Calculate sum, product, and average
                double totalSum = num1 + num2 + num3;
                double product = num1 * num2 * num3;
                double average = totalSum / 3;

                // Display results
                Console.WriteLine($"The sum of the three numbers is {totalSum}.");
                Console.WriteLine($"The product of the three numbers is {product}.");
                Console.WriteLine($"The average of the three numbers is {average:F2}.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter valid numeric values.");
            }
        }
    }
}
