// Last updated: 5/29/2026, 11:54:02 PM
// dffds
1public class TrieNode{
2    public Dictionary<char, TrieNode> children = new Dictionary<char, TrieNode>();
3    public bool isEnd = false;
4}
5
6public class Solution {
7    TrieNode root = new TrieNode();
8private HashSet<string> res = new HashSet<string>();
9    private bool[,] visit;
10    public List<string> FindWords(char[][] board, string[] words) {
11
12        foreach(var w in words)
13{
14    var curr = root;
15
16    foreach(char c in w)
17    {
18        if(!curr.children.ContainsKey(c))
19        {
20            curr.children[c] = new TrieNode();
21        }
22
23        curr = curr.children[c];
24    }
25
26    curr.isEnd = true;
27}
28
29      int ROWS = board.Length, COLS = board[0].Length;
30        visit = new bool[ROWS, COLS];
31
32        for (int r = 0; r < ROWS; r++) {
33            for (int c = 0; c < COLS; c++) {
34                Dfs(board, r, c, root, "");
35            }
36        }
37        return new List<string>(res);
38
39    }
40
41     private void Dfs(char[][] board, int r, int c, TrieNode node, string word) {
42        int ROWS = board.Length, COLS = board[0].Length;
43        if (r < 0 || c < 0 || r >= ROWS ||
44            c >= COLS || visit[r, c] ||
45            !node.children.ContainsKey(board[r][c])) {
46            return;
47        }
48
49        visit[r, c] = true;
50        node = node.children[board[r][c]];
51        word += board[r][c];
52        if (node.isEnd) {
53            res.Add(word);
54        }
55
56        Dfs(board, r + 1, c, node, word);
57        Dfs(board, r - 1, c, node, word);
58        Dfs(board, r, c + 1, node, word);
59        Dfs(board, r, c - 1, node, word);
60
61        visit[r, c] = false;
62    }
63}
64