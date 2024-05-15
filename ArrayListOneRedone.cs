using System;
using System.Collections;

class ArrayListOneRedone
{
   public static void Main(string[] args)
   {
      ArrayList arlist1 = new ArrayList();
      
      arlist1.Add("John");
      arlist1.Add("Maina");
      arlist1.Add(" ");
      arlist1.Add(true);
      arlist1.Add(14.75);
      arlist1.Add(null);
      arlist1.Add(8);
      arlist1.Add("A");

      Console.WriteLine("\nThe elements in the array list are:");
      for(int i = 0; i < arlist1.Count; i++)
      {
         Console.WriteLine(arlist1[i]);
      }
   }
}
