using System;

class SumOne
{
   static void Main(string[] args) 
   {
      double numberOne, numberTwo, total;

      Console.Write("Enter the first number -> ");
      numberOne = Convert.ToDouble(Console.ReadLine());
      Console.Write("Enter the second number -> ");
      numberTwo = Convert.ToDouble(Console.ReadLine());

      total = numberOne + numberTwo;

      Console.WriteLine("The sum is " + total);
   }
}