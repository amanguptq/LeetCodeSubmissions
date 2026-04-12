// Last updated: 4/12/2026, 7:00:28 PM
1public class Solution {
2    public int FindKthLargest(int[] nums, int k) {
3          PriorityQueue<int, int> minHeap = new PriorityQueue<int, int>();
4        foreach (int num in nums) {
5            minHeap.Enqueue(num, num);
6            if (minHeap.Count > k) {
7                minHeap.Dequeue();
8            }
9        }
10        return minHeap.Peek();
11    }
12}