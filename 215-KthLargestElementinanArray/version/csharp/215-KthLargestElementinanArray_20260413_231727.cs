// Last updated: 4/13/2026, 11:17:27 PM
// Very Hard Problem
1public class Twitter {
2
3    Dictionary<int, List<int[]>> tweets;
4    Dictionary<int,HashSet<int>> follows;
5    int time;
6
7    public Twitter() {
8        tweets = new Dictionary<int, List<int[]>>();
9        follows = new Dictionary<int, HashSet<int>>();
10        time = 0;
11        
12    }
13    
14    public void PostTweet(int userId, int tweetId) {
15        if(!tweets.ContainsKey(userId))
16        {
17            tweets[userId] = new List<int[]>();
18        }
19        tweets[userId].Add(new int[] {time++, tweetId});
20
21        
22    }
23    
24    public List<int> GetNewsFeed(int userId) {
25        List<int> res = new List<int>();
26        PriorityQueue<int[], int> min = new PriorityQueue<int[], int>();
27        if(!follows.ContainsKey(userId))
28        {
29        follows[userId] = new HashSet<int>();
30        }
31        follows[userId].Add(userId);
32
33       foreach (int followeeId in follows[userId]) {
34            if (tweets.ContainsKey(followeeId) && tweets[followeeId].Count > 0) {
35                List<int[]> tweet = tweets[followeeId];
36                int index = tweet.Count - 1;
37                int[] latestTweet = tweet[index];
38                min.Enqueue(new int[] { latestTweet[0], latestTweet[1], followeeId, index }, -latestTweet[0]);
39            }
40        }
41
42        while (min.Count > 0 && res.Count < 10) {
43            int[] curr = min.Dequeue();
44            res.Add(curr[1]);
45            int index = curr[3];
46            if (index > 0) {
47                int[] tweet = tweets[curr[2]][index - 1];
48                min.Enqueue(new int[] { tweet[0], tweet[1], curr[2], index - 1 }, -tweet[0]);
49            }
50        }
51
52        return res;
53        
54    }
55    
56    public void Follow(int followerId, int followeeId) {
57        if(!follows.ContainsKey(followerId))
58        {
59            follows[followerId] = new HashSet<int>{followeeId};
60        }
61        follows[followerId].Add(followeeId);
62
63        
64    }
65    
66    public void Unfollow(int followerId, int followeeId) {
67        if(follows.ContainsKey(followerId))
68        {
69            follows[followerId].Remove(followeeId);
70        }
71        
72    }
73}
74
75
76/**
77 * Your Twitter object will be instantiated and called as such:
78 * Twitter obj = new Twitter();
79 * obj.PostTweet(userId,tweetId);
80 * IList<int> param_2 = obj.GetNewsFeed(userId);
81 * obj.Follow(followerId,followeeId);
82 * obj.Unfollow(followerId,followeeId);
83 */