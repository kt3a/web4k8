using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Give me a base of a triangle");
    double thebase = double.Parse(Console.ReadLine());
    Console.WriteLine ("Give me a height of a triangle");
    double theheight = double.Parse(Console.ReadLine());
    double ans = (thebase*theheight)/2;
    Console.WriteLine("The area of your triangle is: " + ans);
  }
}