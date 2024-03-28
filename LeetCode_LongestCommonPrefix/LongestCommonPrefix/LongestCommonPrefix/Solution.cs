public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if (strs.Length == 0 || strs == null)
        {
            return "";
        }
        
        if (strs.Length == 1)
        {
            return strs[0];
        }

        string prefix = strs[0];

        for (int i = 1; i < strs.Length; i++)
        {
            while (!strs[i].StartsWith(prefix))
            {
                prefix = prefix.Substring(0, prefix.Length - 1);
                if (string.IsNullOrEmpty(prefix))
                {
                    return "";
                }
            }
        }

        return prefix;
    }
}