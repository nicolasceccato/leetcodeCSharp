using System;

namespace AddBinary // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "1010";
            string b = "1011";
            Solution solution = new Solution();
            string c = solution.AddBinary(a, b);
            Console.WriteLine(c);
        }
    }
}