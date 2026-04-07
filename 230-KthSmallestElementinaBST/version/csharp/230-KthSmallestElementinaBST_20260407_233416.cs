// Last updated: 4/7/2026, 11:34:16 PM
// Less optimized solution. Can be more optimized
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
16        List<int> sorted = new List<int>();
17        Inorder(root, sorted);
18        return sorted[k-1];
19    }
20
21    private void  Inorder(TreeNode n,List<int> s)
22    {
23        if(n == null) return;
24        Inorder(n.left, s);
25        s.Add(n.val);
26        Inorder(n.right,s);
27    }
28}
29