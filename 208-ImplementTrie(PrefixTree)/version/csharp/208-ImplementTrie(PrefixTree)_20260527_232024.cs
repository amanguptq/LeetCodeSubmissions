// Last updated: 5/27/2026, 11:20:24 PM
// Prefix Trie
1public class TrieNode {
2    public Dictionary<char, TrieNode> children = new Dictionary<char, TrieNode>();
3    public bool endOfWord = false;
4}
5
6public class Trie {
7    private TrieNode root;
8
9    public Trie() {
10        root = new TrieNode();
11    }
12
13    public void Insert(string word) {
14        TrieNode cur = root;
15        foreach (char c in word) {
16            if (!cur.children.ContainsKey(c)) {
17                cur.children[c] = new TrieNode();
18            }
19            cur = cur.children[c];
20        }
21        cur.endOfWord = true;
22    }
23
24    public bool Search(string word) {
25        TrieNode cur = root;
26        foreach (char c in word) {
27            if (!cur.children.ContainsKey(c)) {
28                return false;
29            }
30            cur = cur.children[c];
31        }
32        return cur.endOfWord;
33    }
34
35    public bool StartsWith(string prefix) {
36        TrieNode cur = root;
37        foreach (char c in prefix) {
38            if (!cur.children.ContainsKey(c)) {
39                return false;
40            }
41            cur = cur.children[c];
42        }
43        return true;
44    }
45}
46/**
47 * Your Trie object will be instantiated and called as such:
48 * Trie obj = new Trie();
49 * obj.Insert(word);
50 * bool param_2 = obj.Search(word);
51 * bool param_3 = obj.StartsWith(prefix);
52 */