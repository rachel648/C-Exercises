using System;

class Numberset
{
    static void Main(string[] args)
    {
        Console.Write("How many numbers do you want to enter? ");
        int numCount = Convert.ToInt32(Console.ReadLine());

        int[] numbers = new int[numCount];

        for (int i = 0; i < numCount; i++)
        {
             Console.Write("Enter number {0}:> ", i + 1);
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("\nNumbers before sorting:");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }

        Array.Sort(numbers); 

        Console.WriteLine("\n\nNumbers after sorting:");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }

        Console.WriteLine();
    }
}
