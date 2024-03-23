using System;

class SpecifyEvenOdd
{
 

 static void Main(string[] args)
 {
   Console.Write("Enter number of integers: ");
   int totalSize = Convert.ToInt32(Console.ReadLine());

   int[] numbers = new int[totalSize];

   Console.WriteLine("Enter the integers: ");
   for (int i = 0; i < totalSize; i++)
   {
     numbers[i] = Convert.ToInt32(Console.ReadLine());
   }

static int get_even(int number)
{

 if (number % 2 == 0)
{
  return 1; 
}
else
{
  return 0; 
}
}

   int even = 0, odd = 0;
   int evenSum = 0, oddSum = 0;

   for (int i = 0; i < totalSize; i++)
   {
     int evenOdd = get_even(numbers[i]);

     if (evenOdd == 1)
     {
       Console.WriteLine(numbers[i] + " is an even number");
       even++;
       evenSum += numbers[i];
     }
     else
     {
       Console.WriteLine(numbers[i] + " is an odd number");
       odd++;
       oddSum += numbers[i];
     }
   }

   Console.WriteLine("\nThere is a total of {0} odd numbers and their sum is {1}.", odd, oddSum);
   Console.WriteLine("There is a total of {0} even numbers and their sum is {1}.", even, evenSum);
 }
}
