using System;

class ForSum100
{
   static void Main(string[] args) 
   {
      int k, sum = 0;
      
      for(k = 1;k <= 100;k++)
      {
         sum = sum + k;
      }

      Console.WriteLine("\nThe sum of all numbers between 1 and 100 is " + sum);
   }
}