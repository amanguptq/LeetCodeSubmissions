// Last updated: 4/6/2026, 11:48:48 PM
public class Solution {
    public string MinWindow(string s, string t) {
        
          if (t == "") return "";
        Dictionary<char, int> CS = new Dictionary<char, int>();
        Dictionary<char, int> CT =new Dictionary<char, int>();

        foreach (var c in t)
        {
            if(CT.ContainsKey(c))
            {
                CT[c]++;
            }
            else
            {
                CT[c]=1;
            }
        }

        int have = 0 , need = CT.Count, l=0;
        int MinLength = int.MaxValue;
        int[] sizes = [-1, -1];

        for(int r = 0; r<s.Length; r++)
        {
            if(CS.ContainsKey(s[r]))
            {
                CS[s[r]]++;
            }
            else
            {
                CS[s[r]]=1;
            }

            if((CT.ContainsKey(s[r])) && CT[s[r]] == CS[s[r]])
            {
                have ++;
            }

            while(need == have)
            {
            if ((r - l + 1) < MinLength) {
                    MinLength = r - l + 1;
                    sizes[0] = l;
                    sizes[1] = r;
                }
            CS[s[l]]--;
            if((CT.ContainsKey(s[l])) && CT[s[l]] > CS[s[l]])
            {
                have --;
            }
            l++;

            }
        }

        return MinLength == int.MaxValue ? "" : s.Substring(sizes[0], MinLength);

    }
}
