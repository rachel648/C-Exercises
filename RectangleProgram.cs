using System;

class Rectangle 
{ 
   private double length, width, area, perimeter; 

   public Rectangle(double wid, double leng)
   { 
      length = wid; 
      width = leng; 
   }
   public Rectangle()
   { 
      length = 1; 
      width = 1; 
   }
   public Rectangle(Rectangle theRect)//copy constructor 
   { 
      length = theRect.length; 
      width = theRect.width; 
   } 

   public void input() 
   { 
      Console.WriteLine("Enter the length of the rectangle:> "); 
      length = Convert.ToDouble(Console.ReadLine()); 
      Console.WriteLine("Enter the width of the rectangle:> "); 
      width = Convert.ToDouble(Console.ReadLine());
   }

   public void compute()
   {
      area = width * length;
      perimeter = 2 * (width + length);
   }
   public void display() 
   { 
      Console.WriteLine("Length = " + length); 
      Console.WriteLine("Width = " + width); 
      Console.WriteLine("Area = " + area); 
      Console.WriteLine("Perimeter = " + perimeter);
   }
} 
 
class RectangleProgram 
{ 
   public static void Main() 
   { 
      Rectangle rect1 = new Rectangle(5, 10); 
 
      Console.WriteLine("\nOutput for first rectangle:"); 
      Console.WriteLine("-------------------------------");
      rect1.compute();
      rect1.display(); 
 
      Rectangle rect2 = new Rectangle(rect1);//Making use of the copy constructor.
 
      Console.WriteLine("\nOutput for second rectangle:"); 
      Console.WriteLine("-------------------------------");
      rect2.compute();
      rect2.display();  
   } 
 }                                                                                                                                                                          