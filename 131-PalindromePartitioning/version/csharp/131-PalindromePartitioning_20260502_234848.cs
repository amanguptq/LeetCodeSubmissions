// Last updated: 5/2/2026, 11:48:48 PM
// i don't get it
1public class Solution {
2
3    public List<IList<string>> Partition(string s) {
4        List<IList<string>> res = new List<IList<string>>();
5        List<string> part = new List<string>();
6        Dfs(0, s, part, res);
7        return res;
8    }
9
10    private void Dfs(int i, string s, List<string> part, List<IList<string>> res) {
11        if (i >= s.Length) {
12            res.Add(new List<string>(part));
13            return;
14        }
15        for (int j = i; j < s.Length; j++) {
16            if (IsPali(s, i, j)) {
17                part.Add(s.Substring(i, j - i + 1));
18                Dfs(j + 1, s, part, res);
19                part.RemoveAt(part.Count - 1);
20            }
21        }
22    }
23
24    private bool IsPali(string s, int l, int r) {
25        while (l < r) {
26            if (s[l] != s[r]) {
27                return false;
28            }
29            l++;
30            r--;
31        }
32        return true;
33    }
34}