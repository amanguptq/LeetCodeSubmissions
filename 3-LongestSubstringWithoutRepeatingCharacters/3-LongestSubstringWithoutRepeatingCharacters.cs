// Last updated: 4/6/2026, 11:49:01 PM
public class Solution {
    public int LengthOfLongestSubstring(string s) {
        HashSet<char> input = new HashSet<char>();
        int left = 0, right=0, maxLength=0, CurrentLength;
        for (right = 0; right < s.Length; right++)

        {
            while(input.Contains(s[right]))
            {
                input.Remove(s[left]);
                left=left+1;
            }
            input.Add(s[right]);
            
            CurrentLength = right - left + 1;
            maxLength = Math.Max(CurrentLength, maxLength);
        }

        return maxLength;
        
    }
}