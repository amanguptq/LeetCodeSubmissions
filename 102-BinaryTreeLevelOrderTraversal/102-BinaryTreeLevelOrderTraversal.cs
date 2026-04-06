// Last updated: 4/6/2026, 11:48:43 PM
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
    public IList<IList<int>> LevelOrder(TreeNode root) {
        if(root==null)
        {
            return new List<IList<int>>();
        }

        IList<IList<int>> res = new List<IList<int>>();
        Queue<TreeNode> q= new Queue<TreeNode>();
        q.Enqueue(root);
        int currLevel = 0;

        while(q.Count>0)
        {
            var len = q.Count;
            res.Add(new List<int>());
            for(int i =0; i<len; i++)
            {
                var temp = q.Dequeue();
                res[currLevel].Add(temp.val);

                if(temp.left!=null)
                {
                    q.Enqueue(temp.left);
                }

                if(temp.right!=null)
                {
                    q.Enqueue(temp.right);
                }
            }
            currLevel++;
        }
        return res;
        
    }
}