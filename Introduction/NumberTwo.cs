using System;

class NumberTwo
{
   static void Main(string[] args) 
   {
      double myNumber;

      Console.Write("Enter a number -> ");
      myNumber = Convert.ToDouble(Console.ReadLine());

      Console.WriteLine("The number you entered was " + myNumber);
   }
}