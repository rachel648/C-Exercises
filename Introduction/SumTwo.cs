using System;

class SumTwo
{
   static void Main(string[] args) 
   {
      double numberOne, numberTwo, total;

      Console.Write("Enter the first number -> ");
      numberOne = Convert.ToDouble(Console.ReadLine());
      Console.Write("Enter the second number -> ");
      numberTwo = Convert.ToDouble(Console.ReadLine());

      total = numberOne + numberTwo;

      Console.WriteLine("The sum of " + numberOne + " and " + numberTwo + " is " + total);
   }
}