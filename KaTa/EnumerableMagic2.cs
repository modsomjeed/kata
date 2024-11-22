using System;

public class Kata
{
  public static bool Any(int[] arr, Func<int,bool> fun)
  {
    // Create an any? (JS: any) function that accepts an array and a block (JS: function), 
    // and returns true if the block (/function) 
    // returns true for any item in the array. If the array is empty, the function should return false.
    foreach (var item in arr)
    {
      if (fun(item))
      {
        return true;
      }
    }
    return false;
  }
}