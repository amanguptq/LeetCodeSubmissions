// Last updated: 4/6/2026, 11:48:24 PM
public class Solution {
    public int FindDuplicate(int[] nums) {
        foreach(var n in nums)
        {
            int idx = Math.Abs(n) - 1;
            if(nums[idx]<0)
            {
                return Math.Abs(n);
            }
            nums[idx]*=-1;
        }
        return -1;
        
    }
}