using System;

class JinaUpper
{
   static void Main(string[] args) 
   {
      string jina;

      Console.Write("Enter your name -> ");
      jina = Console.ReadLine().ToUpper();

      Console.WriteLine("Your name is " + jina);
   }
}