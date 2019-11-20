using System;
using System.Linq;

class MainClass {
  public static void Main (string[] args) {
    string col,an,drink,activity;

    Console.WriteLine ("Welcome to the Celebrity Quiz.");
    Console.WriteLine ("We will be deciding who you're spirit celebrity is!");

    //make a few celebrity objects 
    Celebrity ari = new Celebrity("Arianna Grande","pink","seahorse","Cloud Macchiato","Singing");

    //create an array of celebrities here after declaring the objects


    //get user input -- change these to be the colors your celebrities were defined with
    Console.WriteLine("Out of these 5, which is your favorite color:\nPink, Blue, Black, or Red? ");
    col = Console.ReadLine();

    //create a string array with all the user inputs here 

  }


//celebrity calculator method 
  public static Celebrity calculator(Celebrity[] aarray,string[] tresults){

    //celebrity initals, will be counters 
    int a = 0;
    int k = 0;
    int g = 0;
    int r = 0;
    int b = 0;

    foreach (Celebrity c in aarray){
        //compare the user input from the string array to each celebrity 
        //think about the order in which you added the user inputs into the string array 
        

        //if the object's color attribute (use a getter) is equal to the user input color then add one to that celebrity 
        //if ari.getColor.Equals(tresults[0])

        //do this for each of the attributes -- animal, starbucks, and weekend activity


    }


    //code to find the winner -- you will need to add if statements to get the correct return object 
    int[] ppl = new int[5] {a,k,g,r,b};
    int maxValue = ppl.Max();
    int maxIndex = Array.IndexOf(ppl, maxValue);



  }
}


public class Celebrity{
    //create the celebrity class here 

}
