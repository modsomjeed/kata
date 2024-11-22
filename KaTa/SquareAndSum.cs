public static class Kata
{
  public static int SquareSum(int[] numbers)
  {
    // Complete the square sum function so that it squares each number passed into it and then sums the results together.
    int sum = 0;
    foreach (int number in numbers)
    {
      sum += number * number;
    }
    return sum;
  }
}