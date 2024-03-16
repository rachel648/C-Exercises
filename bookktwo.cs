using System;

class Book {

string types;  //field


public void read()  //method
{
Console.WriteLine("read");

}

static void Main (string[] args) {

Book Maths =  new Book();    //object created

Maths.types = "squared";
Console.WriteLine(Maths.types);

Maths.read();

Console.ReadLine();
    
}

}