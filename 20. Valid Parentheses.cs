public class ValidParenthesesClass
{
    public static void InternalMain()
    {
        string testCaseOne = "()";
        string testCaseTwo = "()[]{}";
        string testCaseThree = "((";

        Console.WriteLine("Expected Output: True Actual Output: " + IsValid(testCaseOne));
        Console.WriteLine("Expected Output: True Actual Output: " + IsValid(testCaseTwo));
        Console.WriteLine("Expected Output: False Actual Output: " + IsValid(testCaseThree));
    }
    public static bool IsValid(string s)
    {
        if(s.Length <= 1)
        {
            return false;
        }
        Stack<char> stack = new Stack<char>();
        foreach(char c in s)
        {
            if (c == '(')
            {
                stack.Push(')');
            }
            else if (c == '[')
            {
                stack.Push(']');
            }
            else if(c == '{')
            {
                stack.Push('}');
            }
            else if(stack.Count == 0 || stack.Pop() != c)
            {
                return false;
            }
        }
        return stack.Count == 0;
    }
}
