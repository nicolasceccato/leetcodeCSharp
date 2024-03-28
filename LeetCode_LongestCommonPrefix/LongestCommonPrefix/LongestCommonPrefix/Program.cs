using System;


public class Program
    { 
        static void Main(string[] args)
        {
            string[] strs = new[] { "flower", "flow", "flight" };
            Solution solution = new Solution();
            Console.WriteLine(solution.LongestCommonPrefix(strs));
        }
    }
