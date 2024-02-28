using System;
using System.Collections;

class ArrayListAddRange
{
   public static void Main(string[] args)
   {
      ArrayList arrlist1 = new ArrayList();
      ArrayList arrlist2 = new ArrayList() {78, "Nairobi", " ", false, 64.5, null, 'B'};
      int[] myArray = new int[] {23, 56, 89, 45, 32};

      arrlist1.AddRange(arrlist2); //adding arraylist in arraylist 
      arrlist1.AddRange(myArray); //adding array in arraylist 
      
      Console.WriteLine("\nThe elements in the array list are:");
      for(int i = 0; i < arrlist1.Count; i++)
      {
         Console.WriteLine(arrlist1[i]);
      }
   }
}
