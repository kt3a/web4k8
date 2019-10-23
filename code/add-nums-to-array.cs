using System;

class MainClass {
  public static void Main (string[] args) {
    int[] evenNum = new int[10];
    int num = 2;

    for(int i = 0; i < 10; i++) {
      evenNum[i] = num; // use i for index because it increases with each loop
      num += 2;
      Console.WriteLine(evenNum[i]);
    }
  }
}