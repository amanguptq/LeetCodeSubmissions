// Last updated: 4/12/2026, 12:04:28 AM
1public class Solution {
2    public int[][] KClosest(int[][] points, int k) {
3         var pq = new PriorityQueue<int[], int>();
4
5    foreach (var p in points) {
6        int dist = p[0] * p[0] + p[1] * p[1];
7
8        pq.Enqueue(p, -dist);
9
10        if (pq.Count > k) {
11            pq.Dequeue();
12        }
13    }
14
15    int[][] res = new int[k][];
16    for (int i = 0; i < k; i++) {
17        res[i] = pq.Dequeue();
18    }
19
20    return res;
21    }
22}