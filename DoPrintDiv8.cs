using System;

class DoPrintDiv8
{
   static void Main(string[] args) 
   {
      int i;

      i = 100;
      
      Console.WriteLine("\nThe numbers divisible by 8 between 100 and 300 are:\n");

      do
      {
         if(i % 8 == 0)
            Console.Write(i + " ");
         i = i + 1;
      }while (i <= 300);

      Console.WriteLine();
   }
}