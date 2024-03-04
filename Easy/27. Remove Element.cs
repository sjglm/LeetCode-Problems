public class RemoveElementClass
{
    public static void InternalMain()
    {
        int[] testCaseOne = { 3, 2, 2, 3 };
        int testValOne = 3;
        int[] testCaseTwo = { 0, 1, 2, 2, 3, 0, 4, 2 };
        int testValTwo = 2;

        Console.WriteLine("Expected OUTPUT: 2 Actual Output: " + RemoveElement(testCaseOne, testValOne));
        Console.WriteLine("Expected OUTPUT: 5 Actual Output: " + RemoveElement(testCaseTwo, testValTwo));
    }
    public static int RemoveElement(int[] nums, int val)
    {
        return 1;
    }
}
