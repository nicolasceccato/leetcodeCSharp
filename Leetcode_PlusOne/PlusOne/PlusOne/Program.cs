using System;

namespace PlusOne // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] digits = new int[] { 1, 2, 3 };
            Solution solution = new Solution();
            int[] newDigits = solution.PlusOne(digits);
            for (int i = 0; i < newDigits.Length; i++)
            {
                Console.WriteLine(newDigits[i]);
            }
        }
    }
}