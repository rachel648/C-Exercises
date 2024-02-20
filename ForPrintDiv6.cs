using System;

class ForPrintDiv6
{
   static void Main(string[] args) 
   {
      int i;

      Console.WriteLine("\nNumbers divisible by 6 between 100 and 200 are:\n");
      
      for(i = 100;i <= 200;i++)
      {
         if(i % 6 == 0)
            Console.Write(i + " ");
      }

      Console.WriteLine();
   }
}