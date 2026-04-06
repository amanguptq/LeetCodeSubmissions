// Last updated: 4/6/2026, 11:48:17 PM
public class Solution {
    public bool CheckInclusion(string s1, string s2) {

        if (s1.Length > s2.Length) {
            return false;
        }
        int[] CountS1 = new int[26];
        int[] CountS2 = new int[26];

        int matches = 0;
        for (int i = 0; i<s1.Length; i++)
        {
            CountS1[s1[i]-'a']++;
            CountS2[s2[i]-'a']++;
        }

        for(int i =0; i<26; i++)
        {
            if(CountS1[i]==CountS2[i])
            {
                matches++;
            }
        }

        int l= 0;

        for(int r=s1.Length; r<s2.Length; r++)
        {
            if(matches == 26) return true;

            int index = s2[r] - 'a';
            CountS2[index]++;
            if(CountS2[index] == CountS1[index]) matches++;
            else if(CountS1[index] + 1 == CountS2[index]) matches--;

            index = s2[l] - 'a';
            CountS2[index]--;
            if(CountS2[index] == CountS1[index]) matches++;
            else if(CountS1[index] - 1 == CountS2[index]) matches--;
            l++;
        }

        return matches == 26;
    }
}