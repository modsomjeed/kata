namespace CodeWars;

public class ReverseWords
{
    // Complete the function that accepts a string parameter, and reverses each word in the string. All spaces in the string should be retained.
    // Examples
    // "This is an example!" ==> "sihT si na !elpmaxe"
    // "double  spaces"      ==> "elbuod  secaps"

    public static string ReverseEachWord(string str)
    {
        var words = str.Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            char[] charArray = words[i].ToCharArray();
            Array.Reverse(charArray);
            words[i] = new string(charArray);
        }
        return string.Join(" ", words);
    }
}