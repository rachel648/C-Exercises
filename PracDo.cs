using System;

class Computes
{

static void Main (string [] args)

{

int y=2;

Console.WriteLine("{0,-6} {1,10} {2,10}","Number","square","cube");

do
{

int square= y*y;
int cube = y*square;

Console.WriteLine( "{0,-6} {1,10} {2,10}", y,square,cube);  //writeline
y++;   //updation
}

while(y<=10);

Console.WriteLine(y);


}


}