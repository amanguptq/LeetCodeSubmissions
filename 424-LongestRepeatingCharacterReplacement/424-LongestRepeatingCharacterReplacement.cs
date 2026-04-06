// Last updated: 4/6/2026, 11:48:21 PM
public class Solution {
    public int CharacterReplacement(string s, int k) {

        Dictionary<char, int> occurances = new Dictionary<char, int>();
        int l=0, r=0, maxF =0, res = 0;
        for(r = 0; r<s.Length; r++)
        {
            if(occurances.ContainsKey(s[r]))
            {
                occurances[s[r]]++;

            }
            else{
                occurances[s[r]] = 1;
            }
                        maxF = Math.Max(maxF, occurances[s[r]]);


            while(((r-l+1)-maxF)>k)
            {
               occurances[s[l]]--;
               l++; 
            }

            res = Math.Max(res, r-l+1);

        }

        return res;
        
    }
}

