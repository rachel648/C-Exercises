using System;

class Student
{
   public string name = "John Maina";
   public string adm_no = "SCIT-6789/2021";

   static void Main(string[] args)
   {
      Student stud1 = new Student();

      Console.WriteLine("Name: {0}", stud1.name);
      Console.WriteLine("Admission Number: {0}", stud1.adm_no);
   }
}