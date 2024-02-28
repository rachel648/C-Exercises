using System;
using System.Collections;

class ArrayListAccess
{
   public static void Main(string[] args)
   {
      ArrayList mylist = new ArrayList() {58, "Maina", false, 64.5, 'B', 17}; 

      int num = (int)mylist[0];
      string jina = (string)mylist[1];
      bool result = (bool)mylist[2];
      double num2 = (double)mylist[3];
      char grade = (char)mylist[4];
      var theNumber = mylist[5]; //var holds values of any data type
      
      Console.WriteLine("{0} {1} {2} {3} {4} {5}",num, jina, result, num2, grade, theNumber);
      
      /*Console.WriteLine("\nThe elements in the array list are:");
      for(int i = 0; i < mylist.Count; i++)
      {
         Console.WriteLine(mylist[i]);
      }*/
   }
}
