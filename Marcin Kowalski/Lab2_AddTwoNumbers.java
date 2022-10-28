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
        ListNode wynik=new ListNode();
        ListNode poczatek=wynik;
        int zapamietaj = 0;
        while (l1 != null || l2 !=null){
            if(l1 == null)
                l1 = new ListNode(0);
            else if (l2 == null)
                l2 = new ListNode(0);
            wynik.val = l1.val + l2.val;
            if (zapamietaj > 0){
                wynik.val += zapamietaj;
                zapamietaj = 0;
            }
            if (wynik.val >= 10)
            {
                zapamietaj = wynik.val/10;
                wynik.val = wynik.val%10;            
            }
            
            if (l1.next != null || l2.next !=null){
                ListNode pomoc = new ListNode();
                wynik.next = pomoc;
                wynik = wynik.next;
                l1 = l1.next;
                l2 = l2.next;
            }
            else if (zapamietaj > 0) {
                ListNode pomoc = new ListNode();
                wynik.next = pomoc;
                wynik = wynik.next;
                wynik.val = zapamietaj;
                break;
            }
            else    
                break;
        }
        wynik=poczatek;
        return wynik;
    }
}
