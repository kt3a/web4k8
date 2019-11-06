using System;
//this program will replace the e's in a string with 
class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Give me a string");
    string str = Console.ReadLine();
    
    foreach (char c in str){
      if(c == 'e' | c == 'E'){
        Console.Write("3");
      }
      else{
        Console.Write(c);
      }
    }

  }
}