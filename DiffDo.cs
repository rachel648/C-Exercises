using System;

class DiffDo
{
   static void Main(string[] args) 
   {
      int i;

      i = 100;
      
      do
      {
         Console.WriteLine(i);
         i = i + 1;
      }while (i <= 20);
      Console.WriteLine("\nGoodbye.\n");
   }
}