using System;

class Grade
{
   static void Main(string[] args) 
   {
      char grade;

      Console.Write("Enter the grade you got -> ");
      grade = Convert.ToChar(Console.ReadLine());

      Console.WriteLine("You got grade " + grade);
   }
}