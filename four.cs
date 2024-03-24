using System;

class SupermarketItem
{
    private readonly string _itemCode; 
    public double Price { get; set; }
    public int Quantity { get; set; }
    public double TotalCost { get; private set; }
    public double Discount { get; private set; }
    public double NetCost { get; private set; }

    public SupermarketItem(string itemCode, double price, int quantity)
    {
        if (string.IsNullOrEmpty(itemCode))
        {
            throw new ArgumentException("Item code cannot be null or empty.");
        }

        _itemCode = itemCode;
        Price = price;
        Quantity = quantity;
        CalculateTotalCost();
        CalculateDiscount();
        CalculateNetCost();
    }

    public SupermarketItem() { } 

    ~SupermarketItem() 
    {
        Console.WriteLine($"Item {_itemCode} object disposed.");
    }

    private void CalculateTotalCost()
    {
        TotalCost = Price * Quantity;
    }

    private void CalculateDiscount()
    {
        if (TotalCost > 20000)
        {
            Discount = TotalCost * 0.14;
        }
        else if (TotalCost >= 10000)
        {
            Discount = TotalCost * 0.1;
        }
        else
        {
            Discount = 0;
        }
    }

    private void CalculateNetCost()
    {
        NetCost = TotalCost - Discount;
    }

    public string GetItemCode()
    {
        return _itemCode;
    }

    public override string ToString() 
    {
        return GetItemCode().PadRight(10) + " " +
       Price.ToString("C2").PadLeft(10) + " " +
       Quantity.ToString().PadLeft(10) + " " +
       TotalCost.ToString("C2").PadLeft(15) + " " +
       Discount.ToString("C2").PadLeft(15) + " " +
       NetCost.ToString("C2").PadLeft(15);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of items: ");
        int numItems = int.Parse(Console.ReadLine());

        SupermarketItem[] items = new SupermarketItem[numItems];

        double totalAmount = 0;

        for (int i = 0; i < numItems; i++)
        {
            Console.Write($"\nEnter details for item {i + 1}:\n");
            Console.Write("Product code: ");
            string itemCode = Console.ReadLine();
            Console.Write("Price: ");
            double price = double.Parse(Console.ReadLine());
            Console.Write("Quantity: ");
            int quantity = int.Parse(Console.ReadLine());

            try
            {
                items[i] = new SupermarketItem(itemCode, price, quantity);
                totalAmount += items[i].NetCost;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                i--; // Decrement i to allow user to re-enter details for this item
            }
        }

        Console.WriteLine("\n\nItem Code\tPrice\t\tQuantity\tTotal Cost\tDiscount\t\tNet");
        Console.WriteLine("--------------------------------------------------------------------------");
        foreach (SupermarketItem item in items)
        {
            if (item != null) // Check for null items due to potential exceptions
            {
                Console.WriteLine(item);
            }
        }
        Console.WriteLine("--------------------------------------------------------------------------");
        Console.WriteLine("The total amount payable is " + totalAmount);
    }
}
