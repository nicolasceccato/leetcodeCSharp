using System.Diagnostics.CodeAnalysis;

public class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        
        Console.WriteLine(solution.IsValid("()"));
        Console.WriteLine(solution.IsValid("()[]{}"));
        Console.WriteLine(solution.IsValid("(]"));
        Console.WriteLine(solution.IsValid("([){]}"));
        Console.WriteLine(solution.IsValid("([)(){]}"));

    }
}