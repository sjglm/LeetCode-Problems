namespace LeetCode;

public class LongestCommonPrefixClass
{
    public static void InternalMain()
    {
        string[] testCase1 = { "flower", "flow", "flight" };
        string[] testCase2 = { "dog", "racecar", "car" };
        
        LongestCommonPrefix(testCase1);
        LongestCommonPrefix(testCase2);
    }

    public static string LongestCommonPrefix(string[] strs)
    {
        string output = "";

        char[] splitFirstString = strs[0].ToCharArray();
        char[] splitSecondString = strs[1].ToCharArray();

        int firstStringLength = splitFirstString.Length;
        int secondStringLength = splitSecondString.Length;
        int length;
        if(firstStringLength > secondStringLength)
        {
            length = firstStringLength;
        }
        else
        {
            length = secondStringLength;
        }
        char[] commonLetters = new char[length];
        for(int i = 0; i < length; i++)
        {
            if (splitFirstString[i] == splitSecondString[i])
            {
                commonLetters[i] = splitFirstString[i];
                Console.WriteLine(commonLetters);
                Console.ReadLine();
            }
        }

        return output;
    }
}