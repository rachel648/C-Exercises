using System;

namespace Constructor {

  class Car {   

    // parameterless constructor
    Car() {
      Console.WriteLine("Car Constructor");
    }
 
    static void Main(string[] args) {

      // call constructor
      new Car();
      Console.ReadLine();
     
    }
  }
}