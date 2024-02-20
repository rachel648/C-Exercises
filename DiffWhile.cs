using System;

class DiffWhile
{
   static void Main(string[] args) 
   {
      int i;

      i = 100;
      
      while (i <= 20)
      {
         Console.WriteLine(i);
         i = i + 1;
      }
      Console.WriteLine("\nGoodbye.\n");
   }
}