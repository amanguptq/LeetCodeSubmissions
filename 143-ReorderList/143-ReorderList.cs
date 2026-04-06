// Last updated: 4/6/2026, 11:48:36 PM
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
    public void ReorderList(ListNode head) {
        
        var slow = head;
        var fast = head.next;

        while(fast !=null && fast.next!=null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        var curr = slow.next;
        ListNode prev = null;
        slow.next = null;
        while(curr!=null)
        {
            var temp = curr.next;
            curr.next = prev;
            prev = curr;
            curr = temp;
        }

        var first = head;
        var second = prev;
        while(second!=null)
        {
            var temp1 = first.next;
            var temp2 = second.next;
            first.next = second;
            second.next = temp1;
            first = temp1;
            second = temp2;
        }

    }
}