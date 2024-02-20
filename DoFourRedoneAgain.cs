using System;

class DoFourRedoneAgain
{
   static void Main(string[] args) 
   {
      double q;

      q = 1000;
      
      do
      {
         Console.WriteLine("q = " + Math.Round(q,2,MidpointRounding.ToOdd).ToString("0.00"));//Formatting Output
         q = q / 2;
      }while (q >= 5);
   }
}