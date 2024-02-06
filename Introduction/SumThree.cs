using System;

class SumThree
{
   static void Main(string[] args) 
   {
      double numberOne, numberTwo, total;

      Console.Write("Enter two numbers -> ");
      numberOne = Convert.ToDouble(Console.ReadLine());
      numberTwo = Convert.ToDouble(Console.ReadLine());

      total = numberOne + numberTwo;

      Console.WriteLine("The sum of " + numberOne + " and " + numberTwo + " is " + total);
   }
}