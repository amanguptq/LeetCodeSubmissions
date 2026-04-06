// Last updated: 4/6/2026, 11:48:15 PM
public class KthLargest {

     private PriorityQueue<int, int> minHeap;
    private int k;

    public KthLargest(int k, int[] nums)
    {
        this.k = k;
        minHeap = new PriorityQueue<int, int>();
        foreach (int num in nums)
            Add(num);
    }
    public int Add(int val)
    {
        if (minHeap.Count < k)
            minHeap.Enqueue(val, val);
        else if (val > minHeap.Peek())
        {
            minHeap.Dequeue();
            minHeap.Enqueue(val, val);
        }
        return minHeap.Peek();
    }
}

/**
 * Your KthLargest object will be instantiated and called as such:
 * KthLargest obj = new KthLargest(k, nums);
 * int param_1 = obj.Add(val);
 */