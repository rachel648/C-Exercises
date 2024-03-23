using System;

class Student
{
   private string name, admission_number;
   private int number_of_units;
   private double fee_paid, fee_balance;

   public Student(string jina, string adm)
   {
      name = jina;
      admission_number = adm;
   }

   public void getData()
   {
      Console.Write("Enter the student's name:> ");
      name = Console.ReadLine();
      Console.Write("Enter his/her admission number:> ");
      admission_number = Console.ReadLine();
      Console.Write("Enter the number of units he/she is doing:> ");
      number_of_units = Convert.ToInt32(Console.ReadLine());
      Console.Write("Enter the fee he/she has paid:> ");
      fee_paid = Convert.ToDouble(Console.ReadLine());
   }

   public void compute()
   {
      fee_balance = 90000 - fee_paid;
   }
   public void giveOutput()
   {
      Console.WriteLine("Student's Name: " + name);
      Console.WriteLine("Admission Number: " + admission_number);
      Console.WriteLine("Number of Units: " + number_of_units);
      Console.WriteLine("Fee Paid: " + fee_paid);
      Console.WriteLine("Fee Balance: " + fee_balance);
   }
}

class StudentsConstructorOne
{
   static void Main(string[] args)
   {
      Student stud1 = new Student("John Maina","SCIT-1234/2022");
      
      Console.WriteLine("Analysis for the student (the first time):");
      Console.WriteLine("--------------------------------------");
      stud1.compute();
      stud1.giveOutput();

      Console.WriteLine("\n\nData input for the student:");
      Console.WriteLine("--------------------------------------");
      stud1.getData();
      stud1.compute();

      Console.WriteLine("\n\nAnalysis for the student (second time):");
      Console.WriteLine("--------------------------------------");
      stud1.giveOutput();
   }
}