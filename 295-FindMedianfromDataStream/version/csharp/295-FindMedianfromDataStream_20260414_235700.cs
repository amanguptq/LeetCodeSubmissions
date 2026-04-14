// Last updated: 4/14/2026, 11:57:00 PM
// best
1public class MedianFinder {
2
3 private PriorityQueue<int, int> maxHeap;  // Left half
4    private PriorityQueue<int, int> minHeap; 
5
6
7    public MedianFinder() {
8        maxHeap = new PriorityQueue<int, int>();
9        minHeap = new PriorityQueue<int, int>();
10        
11    }
12    
13    public void AddNum(int num) {
14
15        maxHeap.Enqueue(num, -num);
16        minHeap.Enqueue(maxHeap.Peek(), maxHeap.Dequeue());
17        if (maxHeap.Count < minHeap.Count)
18        maxHeap.Enqueue(minHeap.Peek(), -minHeap.Dequeue());
19
20
21    }
22    
23    public double FindMedian()  => minHeap.Count != maxHeap.Count
24        ? maxHeap.Peek() : (minHeap.Peek() + maxHeap.Peek()) / 2.0;
25}
26
27
28/**
29 * Your MedianFinder object will be instantiated and called as such:
30 * MedianFinder obj = new MedianFinder();
31 * obj.AddNum(num);
32 * double param_2 = obj.FindMedian();
33 */