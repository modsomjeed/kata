using System.Collections.Generic;
using System.Linq;
using System;

public class Kata
{
  public static string SpinWords(string sentence)
  {
    // Write a function that takes in a string of one or more words, and returns the same string, but with all words that have five or more letters reversed (Just like the name of this Kata). Strings passed in will consist of only letters and spaces. Spaces will be included only when more than one word is present.

    // Examples:

    // "Hey fellow warriors"  --> "Hey wollef sroirraw" 
    // "This is a test        --> "This is a test" 
    // "This is another test" --> "This is rehtona test"


    return string.Join(" ", sentence.Split(' ').Select(word => word.Length >= 5 ? new string(word.Reverse().ToArray()) : word));
  }
}