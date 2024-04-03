using System;

namespace LengthOfLastWord // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "Hello World";
            Solution solution = new Solution();
            Console.WriteLine(solution.LengthOfLastWord(s));
        }
    }
}