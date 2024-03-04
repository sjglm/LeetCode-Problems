using LeetCode_Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;

public class EntryPoint
{
    static void Main()
    {
        List<string> programNames = new List<string>();
        programNames.AddRange(File.ReadAllLines("names.csv"));
        foreach (string programName in programNames)
        {
            Console.WriteLine(programName);
        }

        while (true)
        {
            Console.WriteLine("\nWhich LeetCode Problem to Run?");
            int selection = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (selection)
            {
                case 9:
                    Console.WriteLine("Running Problem - 9. Palindrome Number\n");
                    PalindromeNumberClass.InternalMain();
                    break;
                case 14:
                    Console.WriteLine("Running Problem - 14. Longest Common Prefix\n");
                    Console.WriteLine("Under Construction...");
                    //LongestCommonPrefixClass.InternalMain();
                    break;
                case 20:
                    Console.WriteLine("Running Problem - 20. Valid Parentheses\n");
                    ValidParenthesesClass.InternalMain();
                    break;
                case 26:
                    Console.WriteLine("Running Problem - 26. Remove Duplicates from Sorted Array\n");
                    RemoveDuplicatesFromSortedArrayClass.InternalMain();
                    break;
                case 27:
                    Console.WriteLine("Running Problem - 27. Remove Element\n");
                    RemoveElementClass.InternalMain();
                    break;
                case 28:
                    Console.WriteLine("Running Problem - 28. Find the Index of the First Occurrence in a String\n");
                    IndexOfTheFirstOccurenceInAStringClass.InternalMain();
                    break;
                case 58:
                    Console.WriteLine("Running Problem - 58. Length of Last Word\n");
                    LengthOfLastWordClass.InternalMain();
                    break;
                case 66:
                    Console.WriteLine("Running Problem - 66. Plus One\n");
                    PlusOneClass.InternalMain();
                    break;
                case 125:
                    Console.WriteLine("Running Problem - 125. Valid Palindrome\n");
                    ValidPalindromeClass.InternalMain();
                    break;
            }
        }
    }
}
