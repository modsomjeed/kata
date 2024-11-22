using System;

public class Kata
{
  public static int PositiveSum(int[] arr)
  {
    // You get an array of numbers, return the sum of all of the positives ones.

    // Example [1,-4,7,12] => 1 + 7 + 12 = 20

    // Note: if there is nothing to sum, the sum is default to 0.

    int sum = 0;
    foreach (int num in arr)
    {
      if (num > 0)
      {
        sum += num;
      }
    }
    return sum;
  }
}