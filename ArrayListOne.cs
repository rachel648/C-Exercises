using System;
using System.Collections;

class ArrayListOne
{
   public static void Main(string[] args)
   {
      var arlist1 = new ArrayList();
      
      arlist1.Add("John");
      arlist1.Add("Maina");
      arlist1.Add(" ");
      arlist1.Add(true);
      arlist1.Add(14.75);
      arlist1.Add(null);
      arlist1.Add(8);
      arlist1.Add("A");

      Console.WriteLine("\nThe elements in the array list are:");
      foreach(var item in arlist1)
      {
         Console.WriteLine(item);
      }
   }
}
