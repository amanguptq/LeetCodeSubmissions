// Last updated: 4/27/2026, 11:01:34 PM
// contains extra time complexity
1public class Solution 
2{
3    public List<IList<int>> CombinationSum(int[] nums, int target) 
4    {
5        List<IList<int>> res = new List<IList<int>>();
6        permute(nums, res, target, new List<int>(), 0);
7        return res;
8    }
9
10    void permute(int[] nums, List<IList<int>> r, int target, List<int> sums, int start) 
11    {
12        int sum = 0;
13        foreach (int i in sums) 
14        {
15            sum += i;
16        }
17
18        if (sum == target) 
19        {
20            r.Add(new List<int>(sums)); 
21            return;
22        }
23
24        if (sum > target) 
25        {
26            return;
27        }
28
29        for (int i = start; i < nums.Length; i++) 
30        {
31            sums.Add(nums[i]);
32            // Pass 'i' as the start index to allow reuse of the same element
33            permute(nums, r, target, sums, i); 
34            sums.RemoveAt(sums.Count - 1);
35        }
36    }
37}
38