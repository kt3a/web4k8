using System;

class MainClass {
  public static void Main (string[] args) {
    int[] num = {16, 22, 89, 43, 56, 33, 1, 20, 99, 104, 67, 75, 13, 234,47};
    int sum = 0;

    foreach(int i in num) {
      sum += i;
      Console.WriteLine(sum);
    }
  }
}