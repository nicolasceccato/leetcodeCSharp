using System;

namespace SqrtX
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 4;
            
            Solution solution = new Solution();
            int b = solution.MySqrt(a);
            Console.WriteLine(b);
        }
    }
}