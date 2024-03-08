namespace LeetCode;

public class PalindromeNumberClass
{
    public static void InternalMain()
    {
        bool testCase1 = IsPalindrome(121);
        bool testCase2 = IsPalindrome(-121);
        bool testCase3 = IsPalindrome(-10);
        Console.WriteLine("Expected Output: True Actual Output: " + testCase1);
        Console.WriteLine("Expected Output: False Actual Output: " + testCase2);
        Console.WriteLine("Expected Output: False Actual Output: " + testCase3);
    }

    public static bool IsPalindrome(int x)
    {
        string number = x.ToString();
        char[] charArray = number.ToCharArray();
        Array.Reverse(charArray);
        string newNumber = new string(charArray);

        if (newNumber == number)
        {
            return true;
        }
        return false;
    }
}