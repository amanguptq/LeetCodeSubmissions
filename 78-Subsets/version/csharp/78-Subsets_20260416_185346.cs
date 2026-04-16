// Last updated: 4/16/2026, 6:53:46 PM
// Not my solution
1public class Solution {
2
3   public IList<IList<int>> Subsets(int[] nums) {
4    IList<IList<int>> res = new List<IList<int>>();
5    var subset = new List<int>();
6    Dfs(nums, 0, subset, res);
7    return res;
8}
9
10private void Dfs(int[] nums, int i, List<int> subset, IList<IList<int>> res) {
11    if (i >= nums.Length) {
12        res.Add(new List<int>(subset));
13        return;
14    }
15
16    subset.Add(nums[i]);
17    Dfs(nums, i + 1, subset, res);
18
19    subset.RemoveAt(subset.Count - 1);
20    Dfs(nums, i + 1, subset, res);
21}
22}