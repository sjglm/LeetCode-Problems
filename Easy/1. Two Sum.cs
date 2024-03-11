using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Problems
{
    public static class TwoSumNumberClass
    {
        public static void InternalMain()
        {
            int[] testCaseOne = { 2, 7, 11, 15 };
            int testCaseTargetOne = 9;
            int[] testCaseTwo = { 3, 2, 4 };
            int testCaseTargetTwo = 6;
            int[] testCaseThree = { 3, 3 };
            int testCaseTargetThree = 6;

            string resultOne = "[" + string.Join(", ", TwoSum(testCaseOne, testCaseTargetOne)) + "]";
            string resultTwo = "[" + string.Join(", ", TwoSum(testCaseTwo, testCaseTargetTwo)) + "]";
            string resultThree = "[" + string.Join(", ", TwoSum(testCaseThree, testCaseTargetThree)) + "]";

            Console.WriteLine("Expected Output: [0,1] Actual Output: " + resultOne);
            Console.WriteLine("Expected Output: [1,2] Actual Output: " + resultTwo);
            Console.WriteLine("Expected Output: [0,1] Actual Output: " + resultThree);
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> indices = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (indices.ContainsKey(complement))
                {
                    return new int[] { indices[complement], i };
                }

                if (!indices.ContainsKey(nums[i]))
                {
                    indices[nums[i]] = i;
                }
            }
            return nums;
        }
    }
}
