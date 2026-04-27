// Last updated: 4/27/2026, 11:00:28 PM
// most optimized approach
1public class Solution {
2    public List<IList<int>> CombinationSum(int[] nums, int target) {
3        List<IList<int>> res = new List<IList<int>>();
4        backtrack(nums, target, 0, new List<int>(), res);
5        return res;
6    }
7
8    void backtrack(int[] nums, int target, int start, List<int> path, List<IList<int>> res) {
9        if (target == 0) {
10            res.Add(new List<int>(path));
11            return;
12        }
13
14        if (target < 0) return;
15
16        for (int i = start; i < nums.Length; i++) {
17            path.Add(nums[i]);
18            backtrack(nums, target - nums[i], i, path, res);
19            path.RemoveAt(path.Count - 1);
20        }
21    }
22}