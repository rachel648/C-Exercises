using System;

class BankAccount
{
    static void Main(string[] args)
    {
        Console.Write("Enter the amount of money deposited: ");
        double Deposit = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the annual interest rate (e.g., 10 for 10%): ");
        double interestRate = Convert.ToDouble(Console.ReadLine()) / 100; // Convert to decimal percentage

        Console.Write("Enter the target amount: ");
        double targetAmount = Convert.ToDouble(Console.ReadLine());

        double currentAmount = Deposit;
        int year = 0;

                while (currentAmount < targetAmount)
        {
            year++;
            double interestEarned = currentAmount * interestRate;
            currentAmount += interestEarned; 
        }

        Console.WriteLine("\nIt will take " +  year + " years for your money to reach your target.");
        Console.WriteLine("By the end of this period, the amount in your account will be approximately " + currentAmount);
    }
}
