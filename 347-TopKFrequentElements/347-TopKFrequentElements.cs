// Last updated: 4/6/2026, 11:48:22 PM
public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var freq = new Dictionary<int, int>();
        var minHeap = new PriorityQueue<int,int>();

        foreach(var x in nums)
        {
            if(freq.ContainsKey(x))
            {
                freq[x]+=1;
            }
            else
            {
              freq[x]=1;
            }
        }

        foreach(var y in freq)
        {
            minHeap.Enqueue(y.Key, y.Value);
            if(minHeap.Count>k)
            {
                minHeap.Dequeue();
            }
        }
        return minHeap.UnorderedItems.Select(x => x.Element).ToArray();


        

        
    }
}