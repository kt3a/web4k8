using System;

class MainClass {
  public static void Main (string[] args) {
    // Declare variables
    int radius;
    double perimeter, area;
    
    // Provide user with intructions
    Console.Write("Please enter a radius: ");

    radius = int.Parse(Console.ReadLine()); // Save user input
    
    // Calculate perimeter and area
    perimeter = 2 * Math.PI * radius;
    area = Math.PI * Math.POW(radius, 2); // OR radius * radius

    // Output perimeter and area
    Console.WriteLine("The perimeter of the circle is " + perimeter);
    Console.WriteLine("The area of the circle is " + area);
  }
}