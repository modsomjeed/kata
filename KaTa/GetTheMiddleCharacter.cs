public class Kata
{
  public static string GetMiddle(string s)
  {
    // You are going to be given a non-empty string. Your job is to return the middle character(s) of the string.

    // If the string's length is odd, return the middle character.
    // If the string's length is even, return the middle 2 characters.
    // Examples:
    // "test" --> "es"
    // "testing" --> "t"
    // "middle" --> "dd"
    // "A" --> "A"

    if (s.Length % 2 == 0)
    {
        return s.Substring(s.Length / 2 - 1, 2);
    }
    else
    {
        return s.Substring(s.Length / 2, 1);
    }
  }
}