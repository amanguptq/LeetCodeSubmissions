// Last updated: 4/6/2026, 11:48:39 PM
public class Solution {
    public int MaxProfit(int[] prices) {

        int MaxP = 0 ;
        int MinBuy = prices[0];

        foreach(var sell in prices)
        {
            MaxP=Math.Max(MaxP, (sell-MinBuy));
            MinBuy = Math.Min(MinBuy, sell);
        }
        return MaxP;
    }
}