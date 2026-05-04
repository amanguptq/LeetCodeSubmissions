// Last updated: 5/4/2026, 11:35:59 PM
1public class Solution {
2    public List<string> LetterCombinations(string digits) {
3
4        if(digits=="")
5        {
6            return new List<string>();
7        }
8       Dictionary<string, List<string>> chars = new Dictionary<string, List<string>>()
9        {
10            {"2",new List<string>{"a","b","c"}},
11            {"3",new List<string>{"d","e","f"}},
12            {"4",new List<string>{"g","h","i"}},
13            {"5",new List<string>{"j","k","l"}},
14            {"6",new List<string>{"m","n","o"}},
15            {"7",new List<string>{"p","q","r","s"}},
16            {"8",new List<string>{"t","u","v"}},
17            {"9",new List<string>{"w","x","y","z"}}
18        };
19        List<List<string>> lists = new List<List<string>>();
20        foreach(var s in digits)
21        {
22            lists.Add(chars[s.ToString()]);
23        }
24        List<string> res = new List<string>();
25        StringBuilder sb = new StringBuilder();
26        Dfs(lists,0, res, sb);
27        return res;
28    }
29
30    void Dfs( List<List<string>> digits,int start,List<string> res,StringBuilder sb){
31
32        if(sb.Length == digits.Count)
33        {
34            res.Add(new string(sb.ToString()));
35            return;
36        }
37
38        for(int i = start; i<digits.Count;i++)
39        {
40            foreach(var s in digits[i])
41            {
42                sb.Append(s);
43                Dfs(digits,i+1, res, sb);
44                sb.Length--;
45            }
46        }
47
48
49
50    }
51}
52