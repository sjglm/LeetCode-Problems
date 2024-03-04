public class RemoveDuplicatesFromSortedArrayClass
{
    public static void InternalMain()
    {
        int[] testCase1 = { 1, 1, 2 };
        int[] testCase2 = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };

        Console.WriteLine("Expected Output: 2 Actual Output: " + RemoveDuplicates(testCase1));
        Console.WriteLine("Expected Output: 5 Actual Output: " + RemoveDuplicates(testCase2));
    }

    public static int RemoveDuplicates(int[] nums)
    {
        int count = 0;
        int currentNumber = int.MinValue;

        foreach (int i in nums)
        {
            if (currentNumber != i)
            {
                count++;
                nums[count - 1] = i;
            }
            currentNumber = i;
        }
        return count;
    }
}