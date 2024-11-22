public class Kata
{
  public static string[] TowerBuilder(int nFloors)
  {
    // Build Tower
    // Build a pyramid-shaped tower, as an array/list of strings, given a positive integer number of floors. A tower block is represented with "*" character.

    // For example, a tower with 3 floors looks like this:

    // [
    // "  *  ",
    // " *** ", 
    // "*****"
    // ]
    // And a tower with 6 floors looks like this:

    // [
    // "     *     ", 
    // "    ***    ", 
    // "   *****   ", 
    // "  *******  ", 
    // " ********* ", 
    // "***********"
    // ]


    string[] tower = new string[nFloors];
    for (int i = 0; i < nFloors; i++)
    {
        int spaces = nFloors - i - 1;
        int stars = i * 2 + 1;
        tower[i] = new string(' ', spaces) + new string('*', stars) + new string(' ', spaces);
    }
    return tower;
  }
}