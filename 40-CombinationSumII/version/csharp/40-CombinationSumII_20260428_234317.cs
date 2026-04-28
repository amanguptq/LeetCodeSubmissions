// Last updated: 4/28/2026, 11:43:17 PM
/*
 * Time: O(n∗2 
 * n
 *  )
 * 
 * most optimized
*/

1public class Solution {
2    public List<IList<int>> CombinationSum2(int[] candidates, int target) {
3             Array.Sort(candidates);
4        List<IList<int>> res = new List<IList<int>>();
5        Sums(candidates, target, 0, res, new List<int>());
6        return res;
7        
8    }
9
10    private void Sums(int[] list, int target, int start, List<IList<int>> res, List<int> cur)
11    {
12        if(target == 0)
13        {
14            res.Add(new List<int>(cur));
15            return;
16        }
17
18        if(target<0) return ;
19
20        for(int i = start; i<list.Length; i++)
21        {
22            if (i > start && list[i] == list[i - 1]) continue;
23
24        // 🔥 Strong pruning
25                 if (list[i] > target) break;
26                cur.Add(list[i]);
27                Sums(list, target-list[i], i+1, res, cur);
28                cur.RemoveAt(cur.Count - 1);
29
30        }
31    }
32}
33