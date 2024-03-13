using System;

class Circle
{
   private double radius, area, circum;

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
class CircleProgram
{
   static void Main(string[] args)
   {
      Circle circ1 = new Circle();

      circ1.input();
      circ1.compute();
      circ1.output();
   }
}