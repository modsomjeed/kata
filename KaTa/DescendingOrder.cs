using System;

public static class Kata
{
  public static int DescendingOrder(int num)
  {
    // Your task is to make a function that can take any non-negative integer as an argument and return it with its digits in descending order. Essentially, rearrange the digits to create the highest possible number.

    // Examples:
    // Input: 42145 Output: 54421

    // Input: 145263 Output: 654321

    // Input: 123456789 Output: 987654321


    if (num < 0) throw new ArgumentException("Input must be a non-negative integer.");

    char[] digits = num.ToString().ToCharArray();
    Array.Sort(digits);
    Array.Reverse(digits);
    return int.Parse(new string(digits));
  }
}