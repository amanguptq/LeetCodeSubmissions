// Last updated: 4/14/2026, 11:39:14 PM
// Not the best solution
1public class MedianFinder {
2
3  private PriorityQueue<int, int> large; // min-heap
4    private PriorityQueue<int, int> small; // max-heap via negative priority
5
6    public MedianFinder() {
7        large = new PriorityQueue<int, int>();
8        small = new PriorityQueue<int, int>();
9    }
10
11    public void AddNum(int num) {
12        small.Enqueue(num, -num);
13
14        if (small.Count > 0 && large.Count > 0 && small.Peek() > large.Peek()) {
15            int val = small.Dequeue();
16            large.Enqueue(val, val);
17        }
18
19        if (small.Count > large.Count + 1) {
20            int val = small.Dequeue();
21            large.Enqueue(val, val);
22        }
23
24        if (large.Count > small.Count + 1) {
25            int val = large.Dequeue();
26            small.Enqueue(val, -val);
27        }
28    }
29
30    public double FindMedian() {
31        if (small.Count > large.Count) return small.Peek();
32        if (large.Count > small.Count) return large.Peek();
33
34        return (small.Peek() + large.Peek()) / 2.0;
35          
36    }
37}
38
39/**
40 * Your MedianFinder object will be instantiated and called as such:
41 * MedianFinder obj = new MedianFinder();
42 * obj.AddNum(num);
43 * double param_2 = obj.FindMedian();
44 */