using System;

class RectangleProgram
{

public int area, length, width,perimeter;

public void input()

{
Console.WriteLine("Enter length");
length = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter width");
width = Convert.ToInt32(Console.ReadLine());

}

public void calculate()

{
area = length*width;
perimeter = length + width;

}

public void final()
{
Console.WriteLine(area);
Console.WriteLine(perimeter);
}

public static void Main (string[] args)
{

RectangleProgram Rec = new RectangleProgram();
Rec.input();
Rec.calculate();
Rec.final();
}
}


