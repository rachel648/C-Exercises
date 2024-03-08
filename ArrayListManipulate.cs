using System;
using System.Collections;

class ArrayListManipulate
{
   public static void Main(string[] args)
   {
      ArrayList arrlist = new ArrayList(){89, "John", 3.48, "D"};

      arrlist.Insert(1,"Maina");//Inserting one value
      
      Console.WriteLine("\nThe elements in the array list are:");
      foreach(var element in arrlist)
      {
         Console.WriteLine(element);
      }

      ArrayList arrlist2 = new ArrayList() {30,40,50};
      arrlist.InsertRange(2, arrlist2);//Inserting an ArrayList

      Console.WriteLine("\nThe elements in the array list are:");
      foreach(var element in arrlist)
      {
         Console.WriteLine(element);
      }

      arrlist.RemoveAt(1); //Removes the second element - index 1
      arrlist.Remove("John");//Removes the first occurence of "John"

      Console.WriteLine("\nThe elements in the array list are:");
      foreach(var element in arrlist)
      {
         Console.WriteLine(element);
      }

      arrlist.RemoveRange(1,3);//Removes secondm third and fourth elements

      Console.WriteLine("\nThe elements in the array list are:");
      foreach(var element in arrlist)
      {
         Console.WriteLine(element);
      }
   }
}

