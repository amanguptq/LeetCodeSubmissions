// Last updated: 4/6/2026, 11:48:23 PM
public class MedianFinder {

 private PriorityQueue<int, int> maxHeap;  // Left half
    private PriorityQueue<int, int> minHeap; 


    public MedianFinder() {
        maxHeap = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));;
        minHeap = new PriorityQueue<int, int>();
        
    }
    
    public void AddNum(int num) {

        maxHeap.Enqueue(num, num);
        minHeap.Enqueue(maxHeap.Peek(), maxHeap.Dequeue());
        if (maxHeap.Count < minHeap.Count)
        maxHeap.Enqueue(minHeap.Peek(), minHeap.Dequeue());


    }
    
    public double FindMedian()  => minHeap.Count != maxHeap.Count
        ? maxHeap.Peek() : (minHeap.Peek() + maxHeap.Peek()) / 2.0;
}


/**
 * Your MedianFinder object will be instantiated and called as such:
 * MedianFinder obj = new MedianFinder();
 * obj.AddNum(num);
 * double param_2 = obj.FindMedian();
 */