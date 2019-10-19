using System;
//class 1

class MainClass {
  public static void Main (string[] args) 
  {
    Console.WriteLine("Hello World");

    int num = 5;
    string name = "katie";
    bool value = true;
    bool otherValue = false;

    //loop examples
    //while loops repeadidly execute a body of code until //the specified condition is met
    int i = 0;
    while(i < 3)
    {
      Console.WriteLine(i++);
    }


    //do-while loop, logic is at the end of the loop
    int j = 0;
    do
    {
      Console.WriteLine(j++);
    } while(j<3);


    //for loops
    for (int k = 0; k < 3 ; k++)
    {
      if (k  == 0)
      {
        Console.WriteLine("My name is Katie");
      }
      if ( k == 1)
      {
        Console.WriteLine("Welcome to level 3");
      }
      if (k ==2)
      {
        Console.WriteLine("I love coding");
      }

    }

  //infinite for loop
  // for (;;)
  // {
  //   Console.WriteLine("to infinity and beyond");
  // }

  /*for each loops work very well for iterating over a list of items */
  foreach (char c in "programming")
  {
    if (c != Convert.ToChar("o"))
    {
      Console.WriteLine(c + " ");
    }
  }

   }
   
 }