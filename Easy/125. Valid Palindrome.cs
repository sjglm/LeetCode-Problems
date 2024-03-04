using System;
using System.Text.RegularExpressions;

public class ValidPalindromeClass
{
    public static void InternalMain()
    {
        string testCaseOne = "A man, a plan, a canal: Panama";
        string testCaseTwo = "race a car";
        string testCaseThree = " ";

        Console.WriteLine("Expected Output: True Actual Output: " + IsPalindrome(testCaseOne));
        Console.WriteLine("Expected Output: False Actual Output: " + IsPalindrome(testCaseTwo));
        Console.WriteLine("Expected Output: True Actual Output: " + IsPalindrome(testCaseThree));
    }

    static bool IsPalindrome(string s)
    {
        string cleanedString = RemoveNonAlphanumeric(s);
        string loweredString = MakeLowerCase(cleanedString);
        char[] cleanedArray = loweredString.ToCharArray();
        Array.Reverse(cleanedArray);
        string reversedString = new string(cleanedArray);
        if (reversedString == loweredString)
        { 
            return true;
        }
        return false;
    }

    static string RemoveNonAlphanumeric(string s)
    {
        return Regex.Replace(s, @"[^a-zA-Z0-9]", "");
    }
    static string MakeLowerCase(string cleanedString)
    {
        string lower = cleanedString.ToLower();
        return lower;
    }
}
