using System;

class MainClass {
  public static void Main (string[] args) {

    string season;
    int string_length, i, vowel_count;
    
    Console.WriteLine ("What's your favorite season?");
    season = Console.ReadLine();
    string_length = season.Length;

    vowel_count = 0;
    for(i = 0; i < string_length; i++) {
      if(season[i] == 'a' || season[i] == 'A') vowel_count++;
      else if(season[i] == 'e' || season[i] == 'E') vowel_count++;
      else if(season[i] == 'i' || season[i] == 'I') vowel_count++;
      else if(season[i] == 'o' || season[i] == 'O') vowel_count++;
      else if(season[i] == 'u' || season[i] == 'U') vowel_count++;
    }
    Console.WriteLine($"There are {vowel_count} vowels in your favorite season");
  }
}