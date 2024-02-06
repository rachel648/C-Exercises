using System;

class NumberOneRedone
{
   static void Main(string[] args) 
   {
      int myNumber;

      Console.Write("Enter a number -> ");
      myNumber = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("The number you entered was " + myNumber);
   }
}