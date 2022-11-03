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
    public ListNode MiddleNode(ListNode head) {
        int counter = 1;
        ListNode test = new ListNode(head.val, head.next);
        while(test.next != null){
            test.val = test.next.val;
            if(test.next.next != null){
                test.next = test.next.next;
            }else{
                test.next = null;
            }
            counter++;
        }
        counter = counter / 2 + 1;
        for (; counter>1; counter--){
            head.val = head.next.val;
            head.next = head.next.next;
        }
        return head;
    }
}
