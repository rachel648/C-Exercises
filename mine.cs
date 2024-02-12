using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Special Program!");

        // Ask the user for their age
        Console.Write("Please enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        // Check if the age is within the accepted range for the special program
        if (age >= 12 && age <= 18)
        {
            Console.WriteLine("Congratulations! You are eligible for the special program.");
            // Add code here for what happens when the student is eligible
        }
        else
        {
            Console.WriteLine("Sorry, you are not eligible for the special program.");
            // Add code here for what happens when the student is not eligible
        }

        Console.ReadLine(); // Keep the console window open until a key is pressed
    }
}
