// Last updated: 4/26/2026, 11:19:40 PM
// Backtrack solution
1public class Solution {
2    public List<IList<int>> Permute(int[] nums) {
3        List<IList<int>> res = new List<IList<int>>();
4        permute(nums,0, res);
5        return res;
6    }
7
8    void permute(int[] nums, int startindex, List<IList<int>> r)
9    {
10        if(startindex == nums.Length)
11        {
12            r.Add(nums.ToList());
13            return;
14        }
15        HashSet<int> done= new HashSet<int>();
16
17        for(int i=startindex;i<nums.Length; i++)
18        {
19            if(!(done.Contains(nums[i])))
20            {
21                done.Add(nums[i]);
22                var temp = nums[i];
23                nums[i] = nums[startindex];
24                nums[startindex] = temp;
25                permute(nums, startindex+1, r);
26                var temp2 = nums[i];
27                nums[i] = nums[startindex];
28                nums[startindex] = temp2;
29            }
30
31        }
32    }
33}
34