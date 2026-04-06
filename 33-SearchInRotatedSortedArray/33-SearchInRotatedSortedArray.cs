// Last updated: 4/6/2026, 11:48:51 PM
public class Solution {
    public int Search(int[] nums, int target) {
        int res = -1;
        int l = 0, r = nums.Length-1;

        while(l<=r)
        {

            int m = l +(r-l) / 2;

            if(nums[m]==target)
            {
                res = m;
            }
            if(nums[m]>=nums[l])
            {if(target>nums[m] || target<nums[l])
            {
                l = m+1;
            }
            else
            {
                r = m-1;
            }}
            else
            {if(target<nums[m] || target>nums[r])
            {
                r = m-1;
            }
            else
            {
                l = m+1;
            } }

            }
        return res;
        
    }
}