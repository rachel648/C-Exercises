using System;

class Circle
{
   private double radius, area, circum;

   public Circle()
   {
      radius = 7;
   }

   public Circle(double rad)
   {
      radius = rad;
   }

   public void input()
   {
      Console.Write("\nEnter the radius of the circle:> ");
      radius = Convert.ToDouble(Console.ReadLine());
   }

   public void compute()
   {
     area = 22.0 / 7 * radius * radius;
     circum = 22.0 / 7 * radius * 2;
   }

   public void output()
   {
      Console.WriteLine("The area of the rectangle is " + area + " and the circumference is " + circum);
   }
}
class CircleProgramConstructor
{
   static void Main(string[] args)
   {
      Circle circ1 = new Circle();
      Circle circ2 = new Circle(14);

      Console.WriteLine("\nAnalysis for circle 1:");
      Console.WriteLine("---------------------------------------------------------------");
      circ1.compute();
      circ1.output();

      Console.WriteLine("\n\nAnalysis for circle 2:");
      Console.WriteLine("---------------------------------------------------------------");
      circ2.compute();
      circ2.output();
   }
}