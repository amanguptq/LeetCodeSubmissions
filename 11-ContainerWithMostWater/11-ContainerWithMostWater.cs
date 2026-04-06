// Last updated: 4/6/2026, 11:48:59 PM
public class Solution {
    public int MaxArea(int[] height) {

        int max = 0;
        int l =0, r= height.Length - 1;

        while(l<r)
        {
            int area = Math.Min(height[l], height[r]) * (r-l);
            max = Math.Max(max, area);

            if(height[l]<height[r])
            {
                l++;
            }
            else
            {
                r--;
            }

        }

        return max;
    }
}