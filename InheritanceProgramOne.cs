using System;

class Shape
{
   protected double area;

   public void print() 
   {
      Console.WriteLine("The area of the shape is " + area);
   }
} 
class Circle : Shape
{
   private double radius;

   public void getdimension() 
   {
      Console.Write("Enter the radius of the circle:> ");
      radius = double.Parse(Console.ReadLine());
   }
   public void compute() 
   {
      const double PI = 22.0 / 7;
      area = PI * Math.Pow(radius,2);
   }
} 

class InheritanceProgramOne
{
   static void Main(string[] args)
   {
      Circle circ1 = new Circle();

      Console.WriteLine("\nData entry for the circle:");
      Console.WriteLine("----------------------------");
      circ1.getdimension();
      circ1.compute();

      Console.WriteLine("\nAnalysis for the circle:");
      Console.WriteLine("----------------------------");
      circ1.print();
   }
} 