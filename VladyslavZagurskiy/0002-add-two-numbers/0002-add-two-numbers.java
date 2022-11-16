/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     int val;
 *     ListNode next;
 *     ListNode() {}
 *     ListNode(int val) { this.val = val; }
 *     ListNode(int val, ListNode next) { this.val = val; this.next = next; }
 * }
 */
class Solution {
    public ListNode addTwoNumbers(ListNode l1, ListNode l2) {

        ListNode head = new ListNode(0);
        ListNode l3 = head;

        int additionalOne = 0;
        while(l1 != null || l2 != null){
            int n1,n2;

            if(l1 != null)  n1 = l1.val;
            else  n1 = 0;
            if(l2 != null) n2 = l2.val;
            else n2 = 0;

            int sum = n1 + n2 + additionalOne;
            additionalOne = sum / 10;
            int lastOne = sum % 10;

            ListNode new_node = new ListNode(lastOne);
            l3.next = new_node;

            if(l1 != null) l1 = l1.next;
            if(l2 != null) l2 = l2.next;
            l3 = l3.next;
        }

        if(additionalOne == 1){
            ListNode new_node = new ListNode(1);
            l3.next = new_node;
            l3 = l3.next;
        }
        return head.next;
    }
}
