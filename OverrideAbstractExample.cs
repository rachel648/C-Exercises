using System;

abstract class Shape
{
   protected double area;

   public void print() 
   {
      Console.WriteLine("\nThe area is " + area);
   }
   public abstract void compute();
}

class Triangle:Shape
{
   private double baselength, height;

   public void dataIn()
   {
      Console.Write("\nEnter the base of the triangle:> ");
      baselength = Double.Parse(Console.ReadLine());
      Console.Write("Enter the height of the triangle:> ");
      height = double.Parse(Console.ReadLine());
   }
   public override void compute()
   {
      area = 1.0 / 2 * baselength * height;
   }
} 

class OverrideAbstractExample
{
   static void Main(string[] args)
   {
      Triangle tri1 = new Triangle();

      tri1.dataIn();
      tri1.compute();
      tri1.print();
   }
}