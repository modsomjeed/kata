namespace CodeWars;

public class ExesAndOhs
{
    // Check to see if a string has the same amount of 'x's and 'o's. The method must return a boolean and be case insensitive. The string can contain any char.
    // Examples input/output:
    // XO("ooxx") => true
    // XO("xooxx") => false
    // XO("ooxXm") => true
    // XO("zpzpzpp") => true // when no 'x' and 'o' is present should return true
    // XO("zzoo") => false
    public static bool XO(string input)
    {
        int countX = 0;
        int countO = 0;

        foreach (char c in input.ToLower())
        {
            if (c == 'x')
            {
                countX++;
            }
            else if (c == 'o')
            {
                countO++;
            }
        }

        return countX == countO;
    }
}