// Last updated: 4/6/2026, 11:48:41 PM
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
    public bool IsBalanced(TreeNode root) {
         if(root == null)
        {
            return true;
        }

        int left = DFS(root.left);
        int right = DFS(root.right);
        bool res = false;

        if(left == right || left+1 == right || left == right+1)
        {
            res = true;
        }
        else
        {
            res = false;
        }

        //var leftres = IsBalanced(root.left);
        //var rightres = IsBalanced(root.right);

    return res && IsBalanced(root.left) && IsBalanced(root.right);
        
    }

    public int DFS(TreeNode node){
        if(node == null)
        {
            return 0;
        }

        return 1 + Math.Max(DFS(node.left),DFS(node.right));

        
    }
}