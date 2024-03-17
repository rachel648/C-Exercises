using System;

class Rectangle
{
   protected double width, length, area;

   public void getData()
   {
      Console.Write("Enter the width:> ");
      width = double.Parse(Console.ReadLine());
      Console.Write("Enter the length:> ");
      length = double.Parse(Console.ReadLine());
   }

   public void RectangleCompute()
   {
      area = width * length;
   }
   
   public void giveOutput() 
   {
      Console.WriteLine("The area is " + area);
   }
} 
class Cuboid : Rectangle
{
   private double height, volume;

   public void getdimension() 
   {
      getData();
      Console.Write("Enter the height:> ");
      height = double.Parse(Console.ReadLine());
   }

   public void CuboidCompute() 
   {
      RectangleCompute();
      volume = area * height;
   }

   public void output()
   {
      Console.WriteLine("The volume is " + volume);
   }
} 

class InheritanceProgramTwo
{
   static void Main(string[] args)
   {
      Rectangle rect1 = new Rectangle();
      Cuboid cube1 = new Cuboid();

      Console.WriteLine("\nData entry for the rectangle:");
      Console.WriteLine("----------------------------");
      rect1.getData();
      rect1.RectangleCompute();

      Console.WriteLine("\nData entry for the cuboid:");
      Console.WriteLine("----------------------------");
      cube1.getdimension();
      cube1.CuboidCompute();

      Console.WriteLine("\nAnalysis for the rectangle:");
      Console.WriteLine("----------------------------");
      rect1.giveOutput();

      Console.WriteLine("\nAnalysis for the cuboid:");
      Console.WriteLine("----------------------------");
      cube1.output();
   }
} 