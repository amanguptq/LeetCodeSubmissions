// Last updated: 4/6/2026, 11:48:11 PM
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public int GoodNodes(TreeNode root) {
        return DFS(root, root.val);   
    }

    private int DFS(TreeNode n, int max)
    {
        if(n == null)
        {
            return 0;
        }

        int res = 0;

        if(n.val>=max) res+=1;
        max= Math.Max(max, n.val);

        res+= DFS(n.left, max);
        res+= DFS(n.right, max);

        return res;
    }
}