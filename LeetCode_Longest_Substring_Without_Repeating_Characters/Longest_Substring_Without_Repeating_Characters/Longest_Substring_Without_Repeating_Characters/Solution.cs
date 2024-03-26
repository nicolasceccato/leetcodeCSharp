public class Solution {
    public int LengthOfLongestSubstring(string s)
    {
        int maxLenght = 0;
        
        for(int i = 0; i < s.Length; i++)
        {
            HashSet<char> charSet = new HashSet<char>();
            int lenght = 0;
            for (int j = i; j < s.Length; j++)
            {
                if (charSet.Contains(s[j]))
                {
                    break;
                }

                charSet.Add(s[j]);
                lenght++;
            }

            maxLenght = Math.Max(maxLenght, lenght);
        }

        return maxLenght;
    }
}