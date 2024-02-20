using System;

class MathematicalTable
{
   static void Main(string[] args) 
   {
      int i, j;
      
      for(i = 1;i <= 10;i++)
      {
         for(j = 1;j <= 15;j++)
            Console.WriteLine(i + " * " + j + " = " + i * j);
         Console.WriteLine();
      }
   }
}