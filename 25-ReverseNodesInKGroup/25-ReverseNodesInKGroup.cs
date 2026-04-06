// Last updated: 4/6/2026, 11:48:52 PM
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode ReverseKGroup(ListNode head, int k) {

        if(head == null || k<=1)
        {
            return head;
        }

        var fast = head;
        int c = k;

        for (int i = 0; i < k; i++)
        {
        if (fast == null) return head;
        fast = fast.next;
        }

        ListNode prev = null;
        var curr = head;
        while(curr!=fast)
        {
            var temp = curr.next;
            curr.next = prev;
            prev = curr;
            curr = temp;
        }

        head.next = ReverseKGroup(fast, k);
        return prev;
        
    }
}