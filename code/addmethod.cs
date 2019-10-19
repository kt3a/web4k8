using System;

class MainClass {

  public static int add(int a, int b){
    return a + b;
  }
  public static void Main (string[] args) {
    //this is the main method aka the driver function
    int val = add(4,5);
    Console.WriteLine ("Your number is: "+ val);
  }

}