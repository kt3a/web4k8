using System;

class MainClass {
  public static void Main (string[] args) {


    string tans = Console.ReadLine();
    int ans = int.Parse(tans);

    int sum = 1;
    
    while(ans != 1){
      sum *= ans;
      ans -= 1;
    }

    Console.WriteLine(sum);
  }
}