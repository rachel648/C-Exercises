using System;

class Student
{
   private string name, admission_number;
   private int number_of_units;
   private double fee_paid, fee_balance;

   public Student(string jina, string adm,int units,double fee)
   {
      name = jina;
      admission_number = adm;
      number_of_units = units;
      fee_paid = fee;
   }

   public Student(string jina, string adm)
   {
      name = jina;
      admission_number = adm;
   }
  
   public Student()
   {
      name = "";
      admission_number = "";
      number_of_units = 7;
      fee_paid = 0;
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

class StudentsConstructorThree
{
   static void Main(string[] args)
   {
      Student stud1 = new Student("John Maina","SCIT-1234/2022");
      Student stud2 = new Student("Tracey Aluoch","SCIT-8976/2022",9,67000);
      Student stud3 = new Student();
      
      Console.WriteLine("Analysis for student 1 (the first time):");
      Console.WriteLine("--------------------------------------");
      stud1.compute();
      stud1.giveOutput();

      Console.WriteLine("\n\nAnalysis for student 2 (the first time):");
      Console.WriteLine("--------------------------------------");
      stud2.compute();
      stud2.giveOutput();

      Console.WriteLine("\n\nAnalysis for student 3 (the first time):");
      Console.WriteLine("--------------------------------------");
      stud3.compute();
      stud3.giveOutput();

      Console.WriteLine("\n\nData input for student 1:");
      Console.WriteLine("--------------------------------------");
      stud1.getData();
      stud1.compute();

      Console.WriteLine("\n\nAnalysis for student 1 (second time):");
      Console.WriteLine("--------------------------------------");
      stud1.giveOutput();
   }
}