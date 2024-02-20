using System; 

class ForEachTwoAlternative
{ 
   static void Main(string[] args) 
   { 
      int[] numbers = {1,2,3,4,5,6,7,8,9,10}; 
      int i, sum = 0;

      for(i = 0; i < numbers.Length; i++) 
         sum = sum + numbers[i];

      Console.WriteLine("\nThe sum of the numbers in the array is " + sum); 
   } 
}
