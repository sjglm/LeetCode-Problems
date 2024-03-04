using LeetCode;

class PlusOneClass
{
    public static void InternalMain()
    {
        int[] testCaseOne = { 1, 2, 3 };
        int[] testCaseTwo = { 4, 3, 2, 1 };
        int[] testCaseThree = { 9 };
        int[] testCaseFour = { 9, 9 };

        Console.WriteLine("Expected Output: [1,2,4] Actual Output: [" + string.Join(",", PlusOne(testCaseOne)) + "]");
        Console.WriteLine("Expected Output: [4,3,2,2] Actual Output: [" + string.Join(",", PlusOne(testCaseTwo)) + "]");
        Console.WriteLine("Expected Output: [1,0] Actual Output: [" + string.Join(",", PlusOne(testCaseThree)) + "]");
        Console.WriteLine("Expected Output: [1,0,0] Actual Output: [" + string.Join(",", PlusOne(testCaseFour)) + "]");
    }
    public static int[] PlusOne(int[] digits)
    {
        int length = digits.Length;

        if (digits[length - 1] == 9 && length == 1)
        {
            int[] newDigits = new int[2];
            newDigits[0] = 1;
            newDigits[1] = 0;
            return newDigits;
        }
        if (digits[length - 1] == 9 && length > 1)
        {
            for (int i = length - 1; i >= 0; i--)
            {
                if (digits[i] == 9)
                {
                    digits[i] = 0;
                }
                else
                {
                    digits[i]++;
                    return digits;
                }
            }
        }
        else
        {
            digits[length - 1]++;
            return digits;
        }

        int[] newDigitsNew = new int[length + 1];
        newDigitsNew[0] = 1;
        return newDigitsNew;
    }

}