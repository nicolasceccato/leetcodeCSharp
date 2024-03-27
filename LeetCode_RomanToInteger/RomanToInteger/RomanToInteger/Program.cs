namespace RomanToInteger;

public class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        Console.WriteLine(solution.RomanToInt("III"));
        Console.WriteLine(solution.RomanToInt("LVIII"));
        Console.WriteLine(solution.RomanToInt("MCMXCIV"));
    }
}