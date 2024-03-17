using System;

class Vehicle
{
   protected string make, countryOfManuf;
   protected int yearOfManuf;

   public Vehicle(string theMake,string cofManuf, int manufYear)
   {
      make = theMake; 
      countryOfManuf = cofManuf;
      yearOfManuf = manufYear;
   }

   public Vehicle()
   {
      make = ""; 
      countryOfManuf = "";
      yearOfManuf = 2000;
   }

   public void v_input()
   {
      Console.Write("Enter the make of the Vehicle: ");
      make = Console.ReadLine();
      Console.Write("Enter the country of manufacture: ");
      countryOfManuf = Console.ReadLine();
      Console.Write("Enter its year of manufacture: ");
      yearOfManuf = Convert.ToInt32(Console.ReadLine());
   }

   public void v_output()
   {
      Console.WriteLine("Make of the Vehicle: " + make);
      Console.WriteLine("Country of Manufacture: " + countryOfManuf);
      Console.WriteLine("Year of Manufacture: " + yearOfManuf);
   }
}

class Matatu : Vehicle
{
   private string route;
   private int speed_limit,passengers;

   public Matatu(string theMake,string cofManuf, int manufYear,string theRoute, int limit,int capacity) : base(theMake,cofManuf,manufYear)
   {
      route = theRoute;
      speed_limit = limit;
      passengers = capacity;
   }

   public Matatu()
   {
      
      route = "";
      speed_limit = 80;
      passengers = 14;
   }

   public void m_input()
   {
      v_input();

      Console.Write("Enter the matatu's route: ");
      route = Console.ReadLine();
      Console.Write("Enter its speed limit: ");
      speed_limit = Convert.ToInt32(Console.ReadLine());
      Console.Write("Enter the maximum number of passengers: ");
      passengers = Convert.ToInt32(Console.ReadLine());
   }
  
   public void m_output()
   {
	v_output();
	Console.WriteLine("Route: " + route);
	Console.WriteLine("Speed Limit: " + speed_limit + " km/h");
	Console.WriteLine("No of passengers: " + passengers);
   }
}

class Magari
{
   public static void Main(string[] args)
   {
      Vehicle personal = new Vehicle("BMW X6","Germany",2021);
      Matatu mat = new Matatu("Nissan","Japan",2020,"58 Buruburu",90,32);

      Console.WriteLine("\nAnalysis for the personal car (first time): ");
      Console.WriteLine("---------------------------------------------");
      personal.v_output();

      Console.WriteLine("\nAnalysis for the matatu (first time): ");
      Console.WriteLine("---------------------------------------------");
      mat.m_output();

      Console.WriteLine("\nData entry for personal car: ");
      Console.WriteLine("---------------------------------------------");
      personal.v_input();

      Console.WriteLine("\nData entry for the matatu: ");
      Console.WriteLine("---------------------------------------------");
      mat.m_input();

      Console.WriteLine("\nAnalysis for the personal car (second time): ");
      Console.WriteLine("---------------------------------------------");
      personal.v_output();

      Console.WriteLine("\nAnalysis for the matatu (second time): ");
      Console.WriteLine("---------------------------------------------");
      mat.m_output();
   }
}
