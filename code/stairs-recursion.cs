using System;

class MainClass {
  public static int stairs(int n_of_stairs){
    if (n_of_stairs == 1){
      return 1;
    }
    else if (n_of_stairs == 2){
      return 2;
    }

    return stairs(n_of_stairs - 1) + stairs(n_of_stairs - 2);

  }
  public static void Main (string[] args) {
    Console.WriteLine("Give me an integer number of stairs that a person must climb: ");
    int nstairs = int.Parse(Console.ReadLine());
    int ans = stairs(nstairs);

    Console.WriteLine("The number of ways to climb are: " + ans);
  }
}