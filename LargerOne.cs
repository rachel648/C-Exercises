using System;

class LargerOne
{
   static void Main(string[] args) 
   {
      double first, second;

      Console.Write("Enter the first number -> ");
      first = Convert.ToDouble(Console.ReadLine());
      Console.Write("Enter the second number -> ");
      second = Convert.ToDouble(Console.ReadLine());

      if (first > second)
         Console.Write(first + " is larger than " + second);
      else
         Console.Write(second + " is larger than " + first);
   }
}