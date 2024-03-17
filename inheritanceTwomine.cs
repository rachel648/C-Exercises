using System;

class Emotion
{
  public string Feeling { get; set; } // Can represent different emotions

  public void Express()
  {
    if (Feeling == "happy")
    {
      Laugh(); // Call Laugh() directly (without creating an instance)
    }
    else if (Feeling == "sad")
    {
      Cry();
    }
  }

  private void Laugh() // Private to prevent external calls
  {
    Console.WriteLine("I am happy!");
  }

  private void Cry() // Private to prevent external calls
  {
    Console.WriteLine("I am sad...");
  }
}

class DerivedEmotion : Emotion // Inherits from Emotion
{
  public override void Laugh() // Override Laugh() for a different message
  {
    Console.WriteLine("Haha, this is fun!");
    base.Laugh(); // Call the base class Laugh() for additional behavior (optional)
  }
}

class MainClass
{
  static void Main(string[] args)
  {
    DerivedEmotion happyEmotion = new DerivedEmotion();
    happyEmotion.Feeling = "happy";
    happyEmotion.Express(); // Calls Laugh() from DerivedEmotion

    DerivedEmotion sadEmotion = new DerivedEmotion();
    sadEmotion.Feeling = "sad";
    sadEmotion.Express(); // Calls Cry() from Emotion
  }
}
