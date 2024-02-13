using System;

class VowelOne
{
   static void Main(string[] args) 
   {
      char letter;

      Console.Write("\nEnter a letter:> ");
      letter = Convert.ToChar(Console.ReadLine());

      switch(letter)
      {
         case 'a':
         case 'e':
         case 'i':
         case 'o':
         case 'u':Console.WriteLine(letter + " is a vowel.");
                break;
         default:Console.WriteLine(letter + " is NOT a vowel.");
                break;
      }
   }
}