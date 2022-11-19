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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        int overhead = (l1.val + l2.val) / 10;
        ListNode linker = new ListNode(0, null);
        ListNode result = new ListNode((l1.val + l2.val) % 10, null);
        bool skip = false;
        
        l1 = l1.next;
        l2 = l2.next;
        
        if(l1 != null || l2 != null)
        {
            result.next = linker;
        }
        else if(overhead > 0)
        {
            result.next = linker;
            linker.val = overhead;
            overhead = 0;
        }
        
        while(l1 != null)
        {
            skip = true;
            if(l2 != null)
            {
                linker.val = (l1.val + l2.val + overhead) % 10;
                overhead = (l1.val + l2.val + overhead) / 10;
                l1 = l1.next;
                l2 = l2.next;
            }
            else
            {
                linker.val = (l1.val + overhead) % 10;
                overhead = (l1.val + overhead) / 10;
                l1 = l1.next;
            }
            if(l1 != null)
            {
                linker.next = new ListNode(0, null);
                linker = linker.next;
            }
        }
        
        if(l2 != null && skip)
        {
            linker.next = new ListNode(0, null);
            linker = linker.next;
        }
        
        while(l2 != null)
        {
            linker.val = (l2.val + overhead) % 10;
            overhead = (l2.val + overhead) / 10;
            l2 = l2.next;
            if(l2 != null)
            {
                linker.next = new ListNode(0, null);
                linker = linker.next;
            }
        }
        
        if(overhead > 0)
        {
            linker.next = new ListNode(overhead, null);
        }
        
        return result;
    }
}
