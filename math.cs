using System;

class Book {

string types;  //field


public void read()  //method
{
Console.WriteLine("is enjoyable");

}

static void Main (string[] args) {

Book Maths =  new Book();    //object created

Maths.types = "Math is";
Console.WriteLine(Maths.types);

Maths.read();

Console.ReadLine();
    
}

}