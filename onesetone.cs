using System;

public class BeerBrands
{
    public static void Main(string[] args)
    {
        int choice;
    
        Console.WriteLine("* * * * Jamal and Daughters Pub * * * *");
        Console.WriteLine("Beer Brand  Price");
        Console.WriteLine("1) Tusker   100/=");
        Console.WriteLine("2) Pilsner   120/=");
        Console.WriteLine("3) Smirnoff Ice  140/=");
        Console.WriteLine("4) White Cap  90/=");

        Console.WriteLine("Enter your choice:");       //output
        choice = Convert.ToInt32(Console.ReadLine());   //Read User input

     //   Console.WriteLine("Your choice is: " + choice);

        if (choice == 1)
        {
            Console.WriteLine("You have selected Tusker."); // output
        }
        else if (choice == 2)
        {
            Console.WriteLine("You have selected Pilsner."); // corrected typo here
        }
        else if (choice == 3)
        {
            Console.WriteLine("You have selected Smirnoff Ice.");
        }
        else if (choice == 4)
        {
            Console.WriteLine("You have selected White Cap.");
        }
        else
        {
            Console.WriteLine("Invalid choice. Please select a valid option."); // added prompt for invalid choice
        }
        
        
          Console.WriteLine("How many bottles of "+ choice + " do you want?");
          int number = Convert.ToInt32(Console.ReadLine());
          
            Console.WriteLine(number+" bottles will cost you");
       
       if  (choice == 1)
       
       {
            Console.WriteLine(number *100);
        }
        
        else if (choice == 2)
        
        {
            Console.WriteLine(number *120);
        }
        
       else if (choice == 3)
        
        {
            Console.WriteLine(number *140);
        }
        
        else if (choice == 4)
        
        {
            Console.WriteLine(number *90);
        }
        
     
    }
}
