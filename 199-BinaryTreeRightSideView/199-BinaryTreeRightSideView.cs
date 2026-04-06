// Last updated: 4/6/2026, 11:48:30 PM
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
    public IList<int> RightSideView(TreeNode root) {
        //DFS MEthod
        IList<int> res = new List<int>();
        DFS(root, 0, res);
        return res;    
    }

    void DFS(TreeNode n, int depth, IList<int> res)
    {
        if(n == null)
        {
            return;
        }

        if(depth == res.Count)
        {
            res.Add(n.val);
        }

        DFS(n.right, depth+1, res);
        DFS(n.left, depth+1, res);
    }
}