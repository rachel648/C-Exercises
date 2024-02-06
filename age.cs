using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter age:");
        int age = Convert.ToInt32(Console.ReadLine());

        if (age >= 18)
        {
            Console.WriteLine("You can vote.");
        }
        else
        {
            Console.WriteLine("You are too young to vote.");
        }
    }
}
