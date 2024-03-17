using System;

class RectangleProgram
{

public int area, length, width;

public void input()

{
Console.WriteLine("Enter length");
length = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter width");
width = Convert.ToInt32(Console.ReadLine());

area = length*width;

Console.WriteLine(area);

}

public static void Main (string[] args)
{

RectangleProgram Rec = new RectangleProgram();

Rec.input();
}
}


