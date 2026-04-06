// Last updated: 4/6/2026, 11:48:50 PM
public class Solution {
    public int Trap(int[] height) {

        int res = 0;
        int l=0,r = height.Length-1;
        int leftmax = height[l], rightmax = height[r];

        while(l<r){
            if(leftmax>rightmax)
            {
                r--;
                rightmax = Math.Max(rightmax, height[r]);
                res += rightmax - height[r];
            }
            else
            {
                l++;
                leftmax = Math.Max(leftmax, height[l]);
                res += leftmax - height[l];
            }
        }
        return res;
    }
}