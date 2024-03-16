using System;

class Book
{
  // Field to store the book type (use descriptive names)
  public string BookType { get; set; } 

  // Method to simulate reading a book
  public void Read()
  {
    Console.WriteLine("Reading a book...");
  }

  static void Main(string[] args)
  {
    // Create a Book object named mathBook (use camelCase for variable names)
    Book mathBook = new Book();

    // Set the book type
    mathBook.BookType = "Math";

    // Print the book type
    Console.WriteLine($"Book type: {mathBook.BookType}");

    // Call the read method
    mathBook.Read();
  }
}
