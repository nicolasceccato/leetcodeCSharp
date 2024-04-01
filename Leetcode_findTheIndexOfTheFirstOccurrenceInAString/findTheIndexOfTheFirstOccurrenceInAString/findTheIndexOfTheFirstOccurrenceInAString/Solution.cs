namespace findTheIndexOfTheFirstOccurrenceInAString;

public class Solution {
    public int StrStr(string haystack, string needle) {
        if (needle.Length > haystack.Length || !haystack.Contains(needle))
        {
            return -1;
        }
        
        int index = 0;
        index = haystack.IndexOf(needle);

        return index;
    }
}