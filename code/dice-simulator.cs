using System;


class MainClass {
  public static void Main (string[] args) {
    while (true){
      Console.WriteLine ("Hello, would you like to roll the dice?");
      string ans = Console.ReadLine();
      if (ans == "yes") {
        int num = roll();
        Console.WriteLine("You rolled a: " + num);
      }
      if (ans == "no"){
        Console.WriteLine("Goodbye, Come again.");
        break;
      }
    }

  }

  public static int roll(){

    Random random = new Random();
    int randomnum = random.Next(0,6);
    return randomnum;
  }
}