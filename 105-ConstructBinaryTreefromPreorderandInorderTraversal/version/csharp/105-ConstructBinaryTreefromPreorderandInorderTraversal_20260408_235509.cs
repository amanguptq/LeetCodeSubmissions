// Last updated: 4/8/2026, 11:55:09 PM
// Not the best solution
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
15    public TreeNode BuildTree(int[] preorder, int[] inorder) {
16        
17       if (preorder.Length == 0 || inorder.Length == 0) {
18            return null;
19        }
20        TreeNode root = new TreeNode(preorder[0]);
21        var ino = inorder.ToList();
22        var i = ino.IndexOf(preorder[0]);
23         root.left = BuildTree(preorder.Skip(1).Take(i).ToArray(), inorder.Take(i).ToArray());
24        root.right = BuildTree(preorder.Skip(i + 1).ToArray(), inorder.Skip(i + 1).ToArray());
25
26        return root;
27    }
28}