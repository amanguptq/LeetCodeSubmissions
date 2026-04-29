// Last updated: 4/29/2026, 11:36:19 PM
// optimized
1public class Solution {
2 public List<IList<int>> SubsetsWithDup(int[] nums) {
3        Array.Sort(nums);
4        List<IList<int>> res = new List<IList<int>>();
5        backtrack(nums,0, new List<int>(), res);
6        return res;
7    }
8
9    void backtrack(int[] nums, int start, List<int> path, List<IList<int>> res) {
10            res.Add(new List<int>(path)); 
11
12
13        for (int i = start; i < nums.Length; i++) {
14            if (i > start && nums[i] == nums[i - 1]) continue;
15            path.Add(nums[i]);
16            backtrack(nums,  i+1, path, res);
17            path.RemoveAt(path.Count - 1);
18        }
19    }
20}