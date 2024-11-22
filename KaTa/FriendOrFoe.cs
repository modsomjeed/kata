using System.Collections.Generic;
using System.Linq;

namespace CodeWars;

public class FriendOrFoe
{
    public static IEnumerable<string> GetFriends(string[] names)
    {
        // Make a program that filters a list of strings and returns a list with only your friends name in it.
        // If a name has exactly 4 letters in it, you can be sure that it has to be a friend of yours! Otherwise, you can be sure he's not...
        // Input = ["Ryan", "Kieran", "Jason", "Yous"]
        // Output = ["Ryan", "Yous"]
        // Input = ["Peter", "Stephen", "Joe"]
        // Output = []
        // Input strings will only contain letters. Note: keep the original order of the names in the output.
        
        return names.Where(name => name.Length == 4);
    }
}