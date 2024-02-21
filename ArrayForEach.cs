using System;

class ArrayForEach
{
   public static void Main(string[] args)
   {
      double[] numbers = {12,15,23,67,45,76,78,65,67,85};
      double sum = 0, avg; 

      foreach(double theValue in numbers)
      {
         sum = sum + theValue;
      }
      avg = sum / numbers.Length;

      Console.WriteLine("\nThe elements in the array are:\n");
      foreach(double theValue in numbers)
         Console.Write(theValue + " ");
      
      Console.WriteLine("\n\nTheir sum is {0} and average is {1}",sum, avg);
   }
}
