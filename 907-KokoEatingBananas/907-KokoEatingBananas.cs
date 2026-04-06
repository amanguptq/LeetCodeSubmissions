// Last updated: 4/6/2026, 11:48:09 PM
public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int l = 1;
        int r = piles.Max();
        int res = r;
        
        while(l<=r)
        {
            int k = l + (r-l)/2;
            long Time = 0;
            foreach(var i in piles)
            {
                Time += (int)Math.Ceiling((double)i/k);
            }

            if( Time <=h)
            {
                res = k;
                r = k-1;
            }
            else
            {
                l = k+1;
            }

        }

        return res;
        
    }
}