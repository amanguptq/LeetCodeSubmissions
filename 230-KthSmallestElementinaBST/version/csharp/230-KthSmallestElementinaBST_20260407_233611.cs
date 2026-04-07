// Last updated: 4/7/2026, 11:36:11 PM
// Most optimized solution
1/**
2 * Definition for a binary tree node.
3 * public class TreeNode {
4 *     public int val;
5 *     public TreeNode left;
6 *     public TreeNode right;
7 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
8 *         this.val = val;
9 *         this.left = left;
10 *         this.right = right;
11 *     }
12 * }
13 */
14public class Solution {
15    public int KthSmallest(TreeNode root, int k) {
16    Stack<TreeNode> stack = new Stack<TreeNode>();
17
18    while (true) {
19        while (root != null) {
20            stack.Push(root);
21            root = root.left;
22        }
23
24        root = stack.Pop();
25        k--;
26
27        if (k == 0) return root.val;
28
29        root = root.right;
30    }
31}
32}
33