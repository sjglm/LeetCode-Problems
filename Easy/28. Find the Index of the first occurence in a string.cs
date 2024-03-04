namespace LeetCode_Problems
{
    public class IndexOfTheFirstOccurenceInAStringClass
    {
        public static void InternalMain()
        {
            string hayStackOne = "sadbutsad";
            string needleOne = "sad";

            string hayStackTwo = "leetcode";
            string needleTwo = "leeto";

            Console.WriteLine("Expected Output: 0 Actual Output: " + StrStr(hayStackOne, needleOne));
            Console.WriteLine("Expected Output: -1 Actual Output: " + StrStr(hayStackTwo, needleTwo));
        }

        public static int StrStr(string haystack, string needle)
        {
            return haystack.IndexOf(needle);
        }
    }
}