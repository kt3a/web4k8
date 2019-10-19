
using System;

class MainClass {
  public static void Main (string[] args) {
    string name;
    char first_letter;

    Console.WriteLine ("Hello User!");
    Console.WriteLine("What is your name?");
    name = Console.ReadLine();
    Console.WriteLine("Your name is " + name);

    first_letter = Char.ToUpper(name[0]); //ask students why i would add this line

    if (first_letter == 'C') {
      Console.WriteLine("You have a cool name!");
    }
    else {
      Console.WriteLine("Your name is LAME!");
    }
  }
}