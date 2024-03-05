using System;

class Rectangle
{
   protected double width, length, area;

   public void input()
   {
      Console.Write("Enter the width:> ");
      width = double.Parse(Console.ReadLine());
      Console.Write("Enter the length:> ");
      length = double.Parse(Console.ReadLine());
   }

   public void compute()
   {
      area = width * length;
   }
   
   public void output() 
   {
      Console.WriteLine("The area is " + area);
   }
} 
class Cuboid : Rectangle
{
   private double height, volume;

   new public void input() 
   {
      base.input();
      Console.Write("Enter the height:> ");
      height = double.Parse(Console.ReadLine());
   }

   new public void compute() 
   {
      base.compute();
      volume = area * height;
   }

   new public void output()
   {
      Console.WriteLine("The volume is " + volume);
   }
} 

class InheritanceProgramThree
{
   static void Main(string[] args)
   {
      Rectangle rect1 = new Rectangle();
      Cuboid cube1 = new Cuboid();

      Console.WriteLine("\nData entry for the rectangle:");
      Console.WriteLine("----------------------------");
      rect1.input();
      rect1.compute();

      Console.WriteLine("\nData entry for the cuboid:");
      Console.WriteLine("----------------------------");
      cube1.input();
      cube1.compute();

      Console.WriteLine("\nAnalysis for the rectangle:");
      Console.WriteLine("----------------------------");
      rect1.output();

      Console.WriteLine("\nAnalysis for the cuboid:");
      Console.WriteLine("----------------------------");
      cube1.output();
   }
} 