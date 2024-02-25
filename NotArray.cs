using System;

class NotArray
{
   public static void Main(string[] args)
   {
      int num1,num2,num3,num4,num5,num6,num7,num8,num9,num10;
      double sum, avg;

      Console.Write("\nEnter number 1:> ");
      num1 = Convert.ToInt32(Console.ReadLine());
      Console.Write("Enter number 2:> ");
      num2 = Convert.ToInt32(Console.ReadLine());
      Console.Write("Enter number 3:> ");
      num3 = Convert.ToInt32(Console.ReadLine());
      Console.Write("Enter number 4:> ");
      num4 = Convert.ToInt32(Console.ReadLine());
      Console.Write("Enter number 5:> ");
      num5 = Convert.ToInt32(Console.ReadLine());
      Console.Write("Enter number 6:> ");
      num6 = Convert.ToInt32(Console.ReadLine());
      Console.Write("Enter number 7:> ");
      num7 = Convert.ToInt32(Console.ReadLine());
      Console.Write("Enter number 8:> ");
      num8 = Convert.ToInt32(Console.ReadLine());
      Console.Write("Enter number 9:> ");
      num9 = Convert.ToInt32(Console.ReadLine());
      Console.Write("Enter number 10:> ");
      num10 = Convert.ToInt32(Console.ReadLine());
      
      sum = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10;
      avg = sum / 10;

      Console.WriteLine("\nThe average is " + avg);
   }
}