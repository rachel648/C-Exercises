using System;

class Program
{
  static void Main(string[] args)
  {
    Console.Write("Enter the number of items: ");
    int numItems = int.Parse(Console.ReadLine());

    string[] itemCodes = new string[numItems];
    double[] prices = new double[numItems];
    int[] quantities = new int[numItems];
    double[] totalCosts = new double[numItems];
    double[] discounts = new double[numItems];
    double[] netCosts = new double[numItems];

    double totalAmount = 0;

    for (int i = 0; i < numItems; i++)
    {
      Console.Write($"\nEnter details for item {i + 1}:\n");
      
      // Get item details with input validation
      bool validInput = false;
      while (!validInput)
      {
        Console.Write("Product code: ");
        itemCodes[i] = Console.ReadLine();
        if (string.IsNullOrEmpty(itemCodes[i]))
        {
          Console.WriteLine("Item code cannot be null or empty. Please re-enter.");
        }
        else
        {
          validInput = true;
        }
      }

      Console.Write("Price: ");
      prices[i] = double.Parse(Console.ReadLine());

      Console.Write("Quantity: ");
      quantities[i] = int.Parse(Console.ReadLine());

      // Calculate costs for the item
      totalCosts[i] = prices[i] * quantities[i];
      CalculateDiscount(totalCosts[i], discounts, i);  // Call a separate method for discount calculation
      netCosts[i] = totalCosts[i] - discounts[i];

      totalAmount += netCosts[i];
    }

    // Display the final table and total amount
    Console.WriteLine("\n\nItem Code\tPrice\t\tQuantity\tTotal Cost\tDiscount\t\tNet");
    Console.WriteLine("--------------------------------------------------------------------------");
    for (int i = 0; i < numItems; i++)
    {
      Console.WriteLine($"{itemCodes[i],10} {prices[i],10:C2} {quantities[i],10} {totalCosts[i],15:C2} {discounts[i],15:C2} {netCosts[i],15:C2}");
    }
    Console.WriteLine("--------------------------------------------------------------------------");
    Console.WriteLine("The total amount payable is " + totalAmount);
  }

  // Separate method for discount calculation
  static void CalculateDiscount(double totalCost, double[] discounts, int index)
  {
    if (totalCost > 20000)
    {
      discounts[index] = totalCost * 0.14;
    }
    else if (totalCost >= 10000)
    {
      discounts[index] = totalCost * 0.1;
    }
    else
    {
      discounts[index] = 0;
    }
  }
}
