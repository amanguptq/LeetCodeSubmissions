// Last updated: 4/6/2026, 11:48:19 PM
public class Solution {
    public IList<int> FindDuplicates(int[] nums) {
        var freq= new HashSet<int>();
        var res=new List<int>();

       foreach(var s in nums)
        {
            if(freq.Contains(s))
            {
                res.Add(s);
                }
            else
            {
                freq.Add(s);    
            }            
}
        return res;
        }
    }