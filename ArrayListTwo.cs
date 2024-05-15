using System;
using System.Collections;

class ArrayListTwo
{
   public static void Main(string[] args)
   {
      //Adding elements using object initializer syntax
      ArrayList arlist2 = new ArrayList() {78, "Nairobi", " ", false, 64.5, null, 'B'};
      
      Console.WriteLine("\nThe elements in the array list are:");
      for(int i = 0; i < arlist2.Count; i++)
      {
         Console.WriteLine(arlist2[i]);
      }
   }
}
