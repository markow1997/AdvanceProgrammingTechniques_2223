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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        if(list1 == null && list2 == null) return null;
        if(list1 == null) return list2;
        if(list2 == null) return list1;
        ListNode linker = new ListNode();
        ListNode result;
        
        if(list1.val >= list2.val)
        {
            result = new ListNode(list2.val, null);
            list2 = list2.next;
            if(list2 == null)
            {
                result.next = list1;
                return result;
            }
        }
        else
        {
            result = new ListNode(list1.val, null);
            list1 = list1.next;
            if(list1 == null)
            {
                result.next = list2;
                return result;
            }
        }
        if(list1.val >= list2.val)
        {
            linker.val = list2.val;
            linker.next = null;
            result.next = linker;
            list2 = list2.next;
        }
        else
        {
            linker.val = list1.val;
            linker.next = null;
            result.next = linker;
            list1 = list1.next;
        }
        while(list1 != null && list2 != null)
        {
            if(list1.val >= list2.val)
            {
                linker.next = new ListNode(list2.val, null);
                linker = linker.next;
                list2 = list2.next;
            }
            else
            {
                linker.next = new ListNode(list1.val, null);
                linker = linker.next;
                list1 = list1.next;
            }
        }
        while(list1 != null)
        {
            linker.next = new ListNode(list1.val, null);
            linker = linker.next;
            list1 = list1.next;
        }
        while(list2 != null)
        {
            linker.next = new ListNode(list2.val, null);
            linker = linker.next;
            list2 = list2.next;
        }
        
        return result;
    }
}
