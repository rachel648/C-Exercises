using System;
using System.Collections;

class ArrayListClear
{
   public static void Main(string[] args)
   {
      ArrayList arrlist2 = new ArrayList() {78, "Nairobi", " ", false, 64.5, null, 'B'};
      
      Console.WriteLine("\nThe elements in the array list are:");
      for(int i = 0; i < arrlist2.Count; i++)
      {
         Console.WriteLine(arrlist2[i]);
      }

      arrlist2.Clear();//Removes all the elements from arrlist2

      Console.WriteLine("\nThe elements in the array list (Second Time) are:");
      for(int i = 0; i < arrlist2.Count; i++)
      {
         Console.WriteLine(arrlist2[i]);
      }
   }
}
