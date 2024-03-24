using System;

class Animal // Base class for Creature (Inheritance)
{
  private string name;

  public string Name // Properties (Encapsulation)
  {
    get { return name; }
    set { name = value; }
  }

  public Animal(string jina) // Constructors (including default)
  {
    Name = jina;
  }

  public virtual void Introduce() // Overridable method
  {
    Console.WriteLine("Hello, my name is " + Name);
  }
}

class Creature : Animal
{
  private string species;
  private int age;

  public Creature(string jina, string type, int yrs) : base(jina) // Constructor overloading
  {
    species = type;
    age = yrs;
  }

  public Creature(string jina, string type) : base(jina) // Constructor overloading
  {
    species = type;
    age = 1;
  }

  public Creature() : base("") // Default constructor with empty name
  {
    species = "";
    age = 1;
  }

~Creature()   //Destructor
   { 
      Console.WriteLine("\nThe destructor has been called...");
   } 

  public void getData()
  {
    try // Error handling - try catch
    {
      Console.Write("Enter the creature's name:> ");
      Name = Console.ReadLine();
      Console.Write("Enter its species:> ");
      species = Console.ReadLine();
      Console.Write("Enter its age:> ");
      age = Convert.ToInt32(Console.ReadLine());
    }
    catch (FormatException ex) // Catch format exceptions
    {
      Console.WriteLine("Error: Invalid input format. Please try again.");
    }
  }

  public override void Introduce() // Overriding method from Animal
  {
    base.Introduce(); // Call parent class Introduce
    Console.WriteLine("I am a " + species + ".");
  }

  // Properties for species and age (Encapsulation)
  public string Species
  {
    get { return species; }
    set { species = value; }
  }

  public int Age
  {
    get { return age; }
  }

  public void giveOutput()
  {
    Console.WriteLine("Creature's Name: " + Name);
    Console.WriteLine("Species: " + Species); // Use properties
    Console.WriteLine("Age: " + Age); // Use properties
  }
}

class CreaturesConstructorThree
{
  static void Main(string[] args)
  {
    Creature creature1 = new Creature("Leo", "Lion", 5);
    Creature creature2 = new Creature("Luna", "Wolf", 2);
    Creature creature3 = new Creature();

    Console.WriteLine("Analysis for creature 1 (the first time):");
    Console.WriteLine("--------------------------------------");
    creature1.giveOutput();

    Console.WriteLine("\n\nAnalysis for creature 2 (the first time):");
    Console.WriteLine("--------------------------------------");
    creature2.giveOutput();

    Console.WriteLine("\n\nAnalysis for creature 3 (the first time):");
    Console.WriteLine("--------------------------------------");
    creature3.giveOutput();

    Console.WriteLine("\n\nData input for creature 1:");
    Console.WriteLine("--------------------------------------");
    creature1.getData();

    Console.WriteLine("\n\nAnalysis for creature 1 (second time):");
    Console.WriteLine("--------------------------------------");
    creature1.giveOutput();

  }
}
