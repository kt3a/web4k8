using System;

class MainClass {
  public static void Main (string[] args) {
  
    Console.WriteLine ("Hello, tell me your name");
    string name = Console.ReadLine();


    foreach (char c in name)
    {
        if (c == 'a' ){
          Console.WriteLine("*");
        }
        else {
          Console.WriteLine(c);
        }

    }
  
}
}