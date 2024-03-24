using System;

class Person // Base class for Student (Inheritance)
{
    private string name;

    public string Name // Properties (Encapsulation)
    {
        get { return name; }
        set { name = value; }
    }

    public Person(string jina) // Constructors (including default)
    {
        Name = jina;
    }

    public virtual void Introduce() // Overridable method
    {
        Console.WriteLine("Hello, my name is " + Name);
    }
}

class Student : Person
{
    private string admission_number;
    private int number_of_units;
    private double fee_paid, fee_balance;

    public Student(string jina, string adm, int units, double fee) : base(jina) // Constructor overloading
    {
        admission_number = adm;
        number_of_units = units;
        fee_paid = fee;
    }

    public Student(string jina, string adm) : base(jina) // Constructor overloading
    {
        admission_number = adm;
        number_of_units = 7;
        fee_paid = 0;
    }

    public Student() : base("") // Default constructor with empty name
    {
        admission_number = "";
        number_of_units = 7;
        fee_paid = 0;
    }

    public void getData()
    {
        try // Error handling - try catch
        {
            Console.Write("Enter the student's name:> ");
            Name = Console.ReadLine();
            Console.Write("Enter his/her admission number:> ");
            admission_number = Console.ReadLine();
            Console.Write("Enter the number of units he/she is doing:> ");
            number_of_units = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the fee he/she has paid:> ");
            fee_paid = Convert.ToDouble(Console.ReadLine());
        }
        catch (FormatException ex) // Catch format exceptions
        {
            Console.WriteLine("Error: Invalid input format. Please try again.");
        }
    }

    public void compute()
    {
        fee_balance = 90000 - fee_paid;
    }

    public override void Introduce() // Overriding method from Person
    {
        base.Introduce(); // Call parent class Introduce
        Console.WriteLine("I am a student.");
    }

    // Properties for admission_number, number_of_units, fee_paid, and fee_balance (Encapsulation)
    public string AdmissionNumber
    {
        get { return admission_number; }
        set { admission_number = value; }
    }

    public int NumberOfUnits
    {
        get { return number_of_units; }
        set { number_of_units = value; }
    }

    public double FeePaid
    {
        get { return fee_paid; }
        set { fee_paid = value; }
    }

    public double FeeBalance
    {
        get { return fee_balance; } // Read-only property
    }

    public void giveOutput()
    {
        Console.WriteLine("Student's Name: " + Name);
        Console.WriteLine("Admission Number: " + AdmissionNumber); // Use properties
        Console.WriteLine("Number of Units: " + NumberOfUnits); // Use properties
        Console.WriteLine("Fee Paid: " + FeePaid); // Use properties
        Console.WriteLine("Fee Balance: " + FeeBalance); // Use properties
    }
}

class StudentsConstructorThree
{
    static void Main(string[] args)
    {
        Student stud1 = new Student("Rachel Kanyiri", "S316-T");
        Student stud2 = new Student("Shelmith Nelima", "S67-H", 9, 67000);
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
    

