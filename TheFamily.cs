using System;

class Family
{
   private static string surname;
   private string name, dateOfBirth;

   public static void getSurname()
   {
      Console.Write("Enter the surname:> ");
      surname = Console.ReadLine();
   }

   public void dataIn()
   {
      Console.Write("Enter the name:> ");
      name = Console.ReadLine();
      Console.Write("Enter the date of birth:> ");
      dateOfBirth = Console.ReadLine();
   }

   public void dataOut()
   {
      Console.WriteLine("Name: {0} {1}", name, surname);
      Console.WriteLine("Date of Birth: {0}", dateOfBirth);
   }
}
class TheFamily
{
   public static void Main(string[] args)
   {
      Family dad = new Family();
      Family mum = new Family(); 
      Family kid = new Family();

      Console.WriteLine("Family name...");
      Console.WriteLine("--------------------------");
      Family.getSurname();

      Console.WriteLine("\nData entry for the dad");
      Console.WriteLine("--------------------------");
      dad.dataIn();

      Console.WriteLine("\nData entry for the mum");
      Console.WriteLine("--------------------------");
      mum.dataIn();

      Console.WriteLine("\nData entry for the kid");
      Console.WriteLine("--------------------------");
      kid.dataIn();

      Console.WriteLine("\n\nAnalysis for the dad");
      Console.WriteLine("--------------------------");
      dad.dataOut();

      Console.WriteLine("\nAnalysis for the mum");
      Console.WriteLine("--------------------------");
      mum.dataOut();

      Console.WriteLine("\nAnalysis for the kid");
      Console.WriteLine("--------------------------");
      kid.dataOut();
   }
}


