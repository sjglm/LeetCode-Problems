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
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Problem List");
            Console.WriteLine("------------");
            foreach (string programName in programNames)
            {
                Console.WriteLine(programName);
            }

            Console.WriteLine("\nWhich LeetCode Problem to Run?");
            int selection = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (selection)
            {
                case 9:
                    Console.WriteLine("Running Problem - 9. Palindrome Number\n");
                    PalindromeNumberClass.InternalMain();
                    Console.ReadKey();
                    break;
                case 14:
                    Console.WriteLine("Running Problem - 14. Longest Common Prefix\n");
                    Console.WriteLine("Under Construction...");
                    //LongestCommonPrefixClass.InternalMain();
                    Console.ReadKey();
                    break;
                case 20:
                    Console.WriteLine("Running Problem - 20. Valid Parentheses\n");
                    ValidParenthesesClass.InternalMain();
                    Console.ReadKey();
                    break;
                case 26:
                    Console.WriteLine("Running Problem - 26. Remove Duplicates from Sorted Array\n");
                    RemoveDuplicatesFromSortedArrayClass.InternalMain();
                    Console.ReadKey();
                    break;
                case 27:
                    Console.WriteLine("Running Problem - 27. Remove Element\n");
                    RemoveElementClass.InternalMain();
                    Console.ReadKey();
                    break;
                case 28:
                    Console.WriteLine("Running Problem - 28. Find the Index of the First Occurrence in a String\n");
                    IndexOfTheFirstOccurenceInAStringClass.InternalMain();
                    Console.ReadKey();
                    break;
                case 58:
                    Console.WriteLine("Running Problem - 58. Length of Last Word\n");
                    LengthOfLastWordClass.InternalMain();
                    Console.ReadKey();
                    break;
                case 66:
                    Console.WriteLine("Running Problem - 66. Plus One\n");
                    PlusOneClass.InternalMain();
                    Console.ReadKey();
                    break;
                case 125:
                    Console.WriteLine("Running Problem - 125. Valid Palindrome\n");
                    ValidPalindromeClass.InternalMain();
                    Console.ReadKey();
                    break;
            }
        }
    }
}
