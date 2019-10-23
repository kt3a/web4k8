using System;

class MainClass {

  //fact
  public static int factorial(int num){
    //base case -- 1 
    if(num <= 1){
      return 1;
    }
    else{
      //recursive case
      return num * factorial(num -1);
    }
  }

  //Main
  public static void Main(string[] args){
    Console.WriteLine("give num");
    int a = int.Parse(Console.ReadLine());
    int ans = factorial(a);
    Console.WriteLine(ans);
  }
}