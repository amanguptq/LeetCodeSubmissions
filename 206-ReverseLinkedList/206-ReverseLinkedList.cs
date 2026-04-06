// Last updated: 4/6/2026, 11:48:29 PM
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
    public ListNode ReverseList(ListNode head) {

        //Iterative solution
        ListNode prev = null;
        ListNode curr = head;

        while(curr !=null)
        {
            var Temp = curr.next;
            curr.next = prev;
            prev = curr;
            curr = Temp;

        } 

        return prev;
        
    }
}