// Last updated: 4/15/2026, 11:27:53 PM
// ss
1public class Solution {
2    public int LeastInterval(char[] tasks, int n) {
3        int[] count = new int[26];
4        foreach (var task in tasks) {
5            count[task - 'A']++;
6        }
7
8        var maxHeap = new PriorityQueue<int, int>();
9        for (int i = 0; i < 26; i++) {
10            if (count[i] > 0) {
11                maxHeap.Enqueue(count[i], -count[i]);
12            }
13        }
14
15        int time = 0;
16        Queue<int[]> queue = new Queue<int[]>();
17        while (maxHeap.Count > 0 || queue.Count > 0) {
18            if (queue.Count > 0 && time >= queue.Peek()[1]) {
19                int[] temp = queue.Dequeue();
20                maxHeap.Enqueue(temp[0], -temp[0]);
21            }
22            if (maxHeap.Count > 0) {
23                int cnt = maxHeap.Dequeue() - 1;
24                if (cnt > 0) {
25                    queue.Enqueue(new int[] { cnt, time + n + 1 });
26                }
27            }
28            time++;
29        }
30        return time;
31    }
32}