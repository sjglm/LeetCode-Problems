public class LengthOfLastWordClass
{
    public static void InternalMain()
    {
        string testCaseOne = "Hello World";
        string testCaseTwo = "   fly me   to   the moon  ";
        string testCaseThree = "luffy is still joyboy";

        Console.WriteLine("Expected OUTPUT: 5 Actual Output: " + LengthOfLastWord(testCaseOne));
        Console.WriteLine("Expected OUTPUT: 4 Actual Output: " + LengthOfLastWord(testCaseTwo));
        Console.WriteLine("Expected OUTPUT: 6 Actual Output: " + LengthOfLastWord(testCaseThree));
    }
    static int LengthOfLastWord(string s )
    {
        string[] splitString = s.Split((' '), StringSplitOptions.RemoveEmptyEntries);
        int length = splitString.Length - 1;
        return splitString[length].Length;
    }
}
