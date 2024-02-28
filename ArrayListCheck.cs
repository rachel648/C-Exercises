using System;
using System.Collections;

class ArrayListCheck
{
   public static void Main(string[] args)
   {
      ArrayList mylist = new ArrayList(){78, "Nairobi", 12.67, 'E'};

      Console.WriteLine("\nThe ArrayList contains the following values:"); 
      Console.WriteLine("---------------------------------------------"); 
      Console.WriteLine("Nairobi: " + mylist.Contains("Nairobi"));//Will return true
      Console.WriteLine("Kenya: " + mylist.Contains("Kenya"));//Will return false
      Console.WriteLine("78: " + mylist.Contains(78));//Will return true
      Console.WriteLine("82: " + mylist.Contains(82));//Will return false
      Console.WriteLine("A: " + mylist.Contains('A'));//Will return false
      Console.WriteLine("E: " + mylist.Contains('E'));//Will return true     
   }
}

