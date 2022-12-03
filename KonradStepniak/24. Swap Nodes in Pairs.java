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
    public ListNode swapPairs(ListNode head) {
        ListNode temp;
        ListNode temp1 = head;
        ListNode temp2, last = null;
        boolean changedHead = false;

        if (temp1 != null && temp1.next != null) temp2 = temp1.next;
        else return head;

        while (temp2 != null)
        {
            temp = temp2.next;
            temp2.next = temp1;
            temp1.next = temp;
            if (!changedHead) {
                head=temp2;
                changedHead=true;
            }

            if (last != null) {
                last.next = temp2;
            }
            last = temp1;

            if (temp1.next != null) temp1 = temp1.next;
            else return head;
            if (temp1.next != null) temp2 = temp1.next;
            else return head;
        }

        return head;
    }
}