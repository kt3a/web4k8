using System;

class MainClass {
  public static void Main (string[] args) {
    string input;
    int length_in;
    double length_cm;

    Console.Write ("Enter a length in inches: ");

    input = Console.ReadLine();
    length_in = int.Parse(input);
    length_cm = length_in * 2.54;

    Console.WriteLine("The length in centimeters is " + length_cm);
  }
}