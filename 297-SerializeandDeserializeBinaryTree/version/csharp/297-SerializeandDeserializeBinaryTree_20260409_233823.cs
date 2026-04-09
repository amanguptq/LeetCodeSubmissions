// Last updated: 4/9/2026, 11:38:23 PM
// Amazon
1/**
2 * Definition for a binary tree node.
3 * public class TreeNode {
4 *     public int val;
5 *     public TreeNode left;
6 *     public TreeNode right;
7 *     public TreeNode(int x) { val = x; }
8 * }
9 */
10public class Codec {
11
12    // Encodes a tree to a single string.
13    public string serialize(TreeNode root) {
14        List<string> res = new List<string>();
15        dfsSerialize(root, res);
16        return String.Join(",", res);
17    }
18
19    private void dfsSerialize(TreeNode node, List<string> res) {
20        if (node == null) {
21            res.Add("N");
22            return;
23        }
24        res.Add(node.val.ToString());
25        dfsSerialize(node.left, res);
26        dfsSerialize(node.right, res);
27    }
28
29
30    // Decodes your encoded data to tree.
31    public TreeNode deserialize(string data) {
32        string[] vals = data.Split(',');
33        int i = 0;
34        return dfsDeserialize(vals, ref i);
35    }
36
37    private TreeNode dfsDeserialize(string[] vals, ref int i) {
38        if (vals[i] == "N") {
39            i++;
40            return null;
41        }
42        TreeNode node = new TreeNode(Int32.Parse(vals[i]));
43        i++;
44        node.left = dfsDeserialize(vals, ref i);
45        node.right = dfsDeserialize(vals, ref i);
46        return node;
47    }
48}
49
50// Your Codec object will be instantiated and called as such:
51// Codec ser = new Codec();
52// Codec deser = new Codec();
53// TreeNode ans = deser.deserialize(ser.serialize(root));