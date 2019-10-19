using System;

class MainClass {

  public static int add(int a, int b) {
    return a + b;
  }

  public static int subtract(int c, int d) {
    return c - d;
  }

  public static int multiply(int e, int f) {
    return e * f;
  }

  public static double divide(int g, int h) {
    return (double)g / (double)h;
  }

  public static void Main (string[] args) {
    // Declare variables
    int num1, num12;
    string input;

    // Provide user instruction
    Console.WriteLine("What function do you want: ");
    input = Console.ReadLine();

    Console.WriteLine("Give me two integers");
    num1 = int.Parse(Console.ReadLine());
    num12 = int.Parse(Console.ReadLine());

    // Code
    if(input == "+") { // addition if statement
      Console.WriteLine(add(num1, num12));
    }
    else if(input == "-") { // subtraction if statement
      Console.WriteLine(subtract(num1, num12));
    }
    else if(input == "*") { // multiplication if statement
      Console.WriteLine(multiply(num1, num12));
    }
    else if(input == "/") { // division if statement
      Console.WriteLine(divide(num1, num12));
    }
    /*
    Console.WriteLine("Give me a Radius");
    double radius = double.Parse(Console.ReadLine());
    //Math.PI() or 3.14
    double circ = 2*3.14*radius;
    //double area = 3.14*(radius**2);
    double area2 = 3.14*(Math.Pow(radius,2));

    Console.WriteLine("Circ: "+circ+ "Area: "+area2);
    */
  }
}