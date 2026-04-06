// Last updated: 4/6/2026, 11:48:32 PM
public class Solution {
    public int FindMin(int[] nums) {
        int res = nums[0];
        int l = 0, r = nums.Length-1;

        while(l<=r)
        {
            if(nums[l]<nums[r])
            {
                res = Math.Min(res, nums[l]);
            }
            int m = l +(r-l) / 2;
            res = Math.Min(res, nums[m]);

            if(nums[m]>=nums[l])
            {
                l = m+1;
            }
            else
            {
                r = m-1;
            }

        }

        return res;
        
    }
}