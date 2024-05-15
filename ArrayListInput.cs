using System;
using System.Collections;

class ArrayListInput
{
   public static void Main(string[] args)
   {
      ArrayList arrlist = new ArrayList(); 
      int i;

      for(i = 0; i < 5; i++)
      {
         Console.Write("Enter element {0}:> ", i + 1);
         arrlist.Add(Console.ReadLine());
      }
 
      Console.WriteLine("\n\nThe elements in the array list are:");
      for(i = 0; i < arrlist.Count; i++)
      {
         Console.WriteLine(arrlist[i]);
      }
   }
}

