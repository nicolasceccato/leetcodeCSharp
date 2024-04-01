using System;

namespace findTheIndexOfTheFirstOccurrenceInAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string haystack = "sadbutsad";
            string needle = "sad";

            Solution solution = new Solution();

            Console.WriteLine(solution.StrStr(haystack, needle));
        }
    }
}