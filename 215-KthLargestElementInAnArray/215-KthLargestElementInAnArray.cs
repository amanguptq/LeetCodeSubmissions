// Last updated: 4/6/2026, 11:48:28 PM
public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        
        var minHeap = new PriorityQueue<int, int>();

        foreach(var x in nums)
        {
            minHeap.Enqueue(x, x);

            if(minHeap.Count>k)
            {
                minHeap.Dequeue();
            }
        }
        return minHeap.Peek();
    }
}