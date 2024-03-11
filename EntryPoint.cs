using LeetCode_Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;

public class EntryPoint
{
    private static readonly Dictionary<int, Action> problemSolvers = new Dictionary<int, Action>
        {
            { 1, TwoSumNumberClass.InternalMain },
            { 9, PalindromeNumberClass.InternalMain },
            { 14, () => Console.WriteLine("Under Construction...") },
            { 20, ValidParenthesesClass.InternalMain },
            { 26, RemoveDuplicatesFromSortedArrayClass.InternalMain },
            { 27, RemoveElementClass.InternalMain },
            { 28, IndexOfTheFirstOccurenceInAStringClass.InternalMain },
            { 58, LengthOfLastWordClass.InternalMain },
            { 66, PlusOneClass.InternalMain },
            { 125, ValidPalindromeClass.InternalMain },
            { 206, ReverseLinkedListClass.InternalMain }
        };
    public static void Main()
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
            if (problemSolvers.ContainsKey(selection))
            {
                Console.WriteLine($"Running Problem - {selection}");
                problemSolvers[selection]();
            }
            else
            {
                Console.WriteLine("Invalid selection. Please try again.");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
