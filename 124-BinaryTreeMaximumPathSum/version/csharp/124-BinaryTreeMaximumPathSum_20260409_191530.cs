// Last updated: 4/9/2026, 7:15:30 PM
// Best Solution
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
15int maxSum = int.MinValue;
16    public int MaxPathSum(TreeNode root) {
17        Sum(root);
18        return maxSum;
19    }
20
21    public int Sum(TreeNode n)
22    {
23        if(n == null)
24        {
25            return 0;
26        }
27        int leftGain = Math.Max(Sum(n.left),0);
28        int rightGain = Math.Max(Sum(n.right),0);
29
30        int sum = n.val + leftGain +rightGain;
31        maxSum = Math.Max(maxSum, sum);
32        return n.val + Math.Max(rightGain, leftGain);
33
34        
35    }        
36    }
37