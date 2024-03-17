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

   public double Radius
   {
      get
      {
         return radius;
      }
      set
      {
         if(value < 0)
         {
            Console.WriteLine("Please Enter value. The radius cannot be negative\a\a\a\n");
            Radius=Convert.ToDouble(Console.ReadLine());
         }
         else
            radius = value;
      }
   }
}
class CircleProgramThree
{
   static void Main(string[] args)
   {
      Circle circ1 = new Circle();

      Console.WriteLine("\nThe circle the first time:");
      circ1.input();
      circ1.compute();
      circ1.output();

      Console.WriteLine("\nThe radius is " + circ1.Radius);//Output of radius using properties

      Console.WriteLine("\nThe circle the second time:");
      circ1.Radius = -7;//setting the value of radius using properties
      circ1.compute();
      circ1.output();
   }
}