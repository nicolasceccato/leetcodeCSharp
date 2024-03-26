public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {

        int start = 0;
        int end = 0;

        int maxLenght = 0;

        HashSet<char> charSet = new HashSet<char>();

        while (end < s.Length)
        {
            if (!charSet.Contains(s[end]))
            {
                charSet.Add(s[end]);
                end++;
                maxLenght = Math.Max(maxLenght, (end - start));
            }
            else
            {
                charSet.Remove(s[start]);
                start++;
            }
        }

        return maxLenght;
    }
}