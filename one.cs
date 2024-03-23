using System;

class DescendPattern
{
  static void Main(string[] args)
  {
    for (int i = 8; i >= 1; i--) 
    {
      for (int j = 1; j <= i; j++) 
      {
        Console.Write(j + " ");
      }
      Console.WriteLine(); 
    }
  }
}
