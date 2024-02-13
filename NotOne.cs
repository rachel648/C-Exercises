using System;

class NotOne
{
   static void Main(string[] args) 
   {
      double first, second;

      Console.Write("\nEnter the first number -> ");
      first = Convert.ToDouble(Console.ReadLine());
      Console.Write("Enter the second number -> ");
      second = Convert.ToDouble(Console.ReadLine());

      if (!(first > second))
         Console.WriteLine("\n{0} is larger than {1}",second, first);
      else
         Console.WriteLine("\n{0} is larger than {1}",first, second);
   }
}