namespace LengthOfLastWord;

public class Solution {
    public int LengthOfLastWord(string s)
    {
        string[] values = s.Trim().Split(' ');
        int size = values.Length;

        string lastWord = values[size - 1];
        return lastWord.Length;
    }
}