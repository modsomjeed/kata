public class ShortestWord
{
    public static int FindShort(string s)
    {
        // Simple, given a string of words, return the length of the shortest word(s).
        // String will never be empty and you do not need to account for different data types.

        string[] words = s.Split(' ');
        int shortest = words[0].Length;
        foreach (string word in words)
        {
            if (word.Length < shortest)
            {
                shortest = word.Length;
            }
        }
        return shortest;
    }
}