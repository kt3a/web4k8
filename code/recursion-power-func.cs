using System;

class MainClass {

  public static double power(double num, int pow){
    //take two numbers and compute the power -- 2**2 but as a function
    //base case
    if (pow == 1){
      return num;
    }
    //recursive case
    else{
      return num * power(num, pow - 1);
    }
  }

  public static void Main (string[] args) {
    Console.WriteLine("Give me any number and the power as an integer that you want to raise it too: ");
    double num = double.Parse(Console.ReadLine());
    int pow_num = int.Parse(Console.ReadLine());
    double ans = power(num,pow_num);

    Console.WriteLine(num + " to the power of " + pow_num + " equals "+ ans);

  }
}