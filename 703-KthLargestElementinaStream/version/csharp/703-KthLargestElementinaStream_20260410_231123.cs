// Last updated: 4/10/2026, 11:11:23 PM
// simple queue
1public class KthLargest {
2
3 private PriorityQueue<int, int> minHeap;
4    private int k;
5
6    public KthLargest(int k, int[] nums) {
7        this.k = k;
8        this.minHeap = new PriorityQueue<int, int>();
9        foreach (int num in nums) {
10            minHeap.Enqueue(num, num);
11            if (minHeap.Count > k) {
12                minHeap.Dequeue();
13            }
14        }
15    }
16
17    public int Add(int val) {
18        minHeap.Enqueue(val, val);
19        if (minHeap.Count > k) {
20            minHeap.Dequeue();
21        }
22        return minHeap.Peek();
23    }
24}
25
26/**
27 * Your KthLargest object will be instantiated and called as such:
28 * KthLargest obj = new KthLargest(k, nums);
29 * int param_1 = obj.Add(val);
30 */