namespace LeetCode;

public class LongestCommonPrefixClass
{
    public static void InternalMain()
    {
        string[] testCase1 = { "flower", "flow", "flight" };
        string[] testCase2 = { "dog", "racecar", "car" };

        Console.WriteLine("Expected Output: fl Actual Output: " + LongestCommonPrefix(testCase1));
        Console.WriteLine("Expected Output: Actual Output: " + LongestCommonPrefix(testCase2));
    }

    public static string LongestCommonPrefix(string[] strs)
    {
        return "hello";
    }
}