using System;

class TaxCalculator
{
    static void Main(string[] args)
    {
        // Prompt the user to enter the gross pay
        Console.WriteLine("Enter the gross pay:");
        double grossPay = Convert.ToDouble(Console.ReadLine());

        // Initialize variables for tax rate and tax amount
        double taxRate = 0;
        double taxAmount = 0;

        // Determine the tax rate based on the gross pay
        if (grossPay >= 40000)
        {
            taxRate = 0.30;
        }
        else if (grossPay >= 30000 && grossPay < 40000)
        {
            taxRate = 0.25;
        }
        else if (grossPay >= 20000 && grossPay < 30000)
        {
            taxRate = 0.15;
        }
        else if (grossPay >= 10000 && grossPay < 20000)
        {
            taxRate = 0.10;
        }
        else
        {
            taxRate = 0; // No tax for gross pay below 10,000
        }

        // Calculate the tax amount
        taxAmount = grossPay * taxRate;

        // Calculate the net pay
        double netPay = grossPay - taxAmount;

        // Output the results
        Console.WriteLine("\nGross Pay: $" + grossPay);
        Console.WriteLine("Tax Rate: " + (taxRate * 100) + "%");
        Console.WriteLine("Tax Amount: $" + taxAmount);
        Console.WriteLine("Net Pay: $" + netPay);
    }
}
