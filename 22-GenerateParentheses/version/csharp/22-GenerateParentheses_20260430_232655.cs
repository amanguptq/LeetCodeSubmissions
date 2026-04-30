// Last updated: 4/30/2026, 11:26:55 PM
// best sol
1public class Solution {  
2public List<string> GenerateParenthesis(int n) {
3    List<string> res = new List<string>();
4    StringBuilder s = new StringBuilder();
5        Backtrack(res, s, n, n);
6    return res;
7}
8
9private void Backtrack(List<string> res, StringBuilder sb, int open, int close)
10{
11    if (open == 0 && close == 0)
12    {
13        res.Add(sb.ToString());
14        return;
15    }
16
17    if (open > 0)
18    {
19        sb.Append("(");
20        Backtrack(res, sb, open - 1, close);
21        sb.Length--; // backtrack
22    }
23
24    if (close > open)
25    {
26        sb.Append(")");
27        Backtrack(res, sb, open, close - 1);
28        sb.Length--; // backtrack
29    }
30}
31}
32