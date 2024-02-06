using System;

class GradeTwo
{
   static void Main(string[] args) 
   {
      char grade;

      Console.Write("Enter the grade you got -> ");
      grade = Convert.ToChar(Console.ReadLine().ToUpper());

      Console.WriteLine("You got grade " + grade);
   }
}