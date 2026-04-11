// Last updated: 4/11/2026, 11:24:08 PM
// not the most efficient
1public class Solution {
2    public int LastStoneWeight(int[] stones) {
3                PriorityQueue<int, int> minHeap = new PriorityQueue<int, int>();
4        foreach (int s in stones) {
5            minHeap.Enqueue(-s, -s);
6        }
7
8        while (minHeap.Count > 1) {
9            int first = minHeap.Dequeue();
10            int second = minHeap.Dequeue();
11            if (second > first) {
12                minHeap.Enqueue(first - second, first - second);
13            }
14        }
15
16        minHeap.Enqueue(0, 0);
17        return Math.Abs(minHeap.Peek());
18    }
19}