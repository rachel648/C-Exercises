using System;

class Laugh
{
public string Human;

public void laugh()

{
      Console.WriteLine("I am happy ");
   }

}

class Sad  : Laugh
{

public void Cry()

{
      Console.WriteLine("I am sad");
   }

}

class Emotion
{

 static void Main(string[] args)
   {

Console.WriteLine("I am human");
 
Laugh emotion1 = new Laugh();
emotion1.Human= "normal";
emotion1.laugh();

}
}

