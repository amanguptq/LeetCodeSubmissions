// Last updated: 5/28/2026, 11:33:49 PM
// TrieNode with DFS
1public class TrieNode
2{
3    public Dictionary<char, TrieNode> children = new Dictionary<char, TrieNode>();
4    public bool endOfWord = false;
5}
6
7public class WordDictionary
8{
9    private TrieNode root;
10
11    public WordDictionary()
12    {
13        root = new TrieNode();
14    }
15
16    public void AddWord(string word)
17    {
18        TrieNode curr = root;
19
20        foreach (char c in word)
21        {
22            if (!curr.children.ContainsKey(c))
23            {
24                curr.children[c] = new TrieNode();
25            }
26
27            curr = curr.children[c];
28        }
29
30        curr.endOfWord = true;
31    }
32
33    public bool Search(string word)
34    {
35        return DFS(word, 0, root);
36    }
37
38    private bool DFS(string word, int index, TrieNode node)
39    {
40        if (index == word.Length)
41        {
42            return node.endOfWord;
43        }
44
45        char c = word[index];
46
47        if (c == '.')
48        {
49            foreach (var child in node.children.Values)
50            {
51                if (DFS(word, index + 1, child))
52                {
53                    return true;
54                }
55            }
56
57            return false;
58        }
59
60        if (!node.children.ContainsKey(c))
61        {
62            return false;
63        }
64
65        return DFS(word, index + 1, node.children[c]);
66    }
67}
68
69/**
70 * Your WordDictionary object will be instantiated and called as such:
71 * WordDictionary obj = new WordDictionary();
72 * obj.AddWord(word);
73 * bool param_2 = obj.Search(word);
74 */