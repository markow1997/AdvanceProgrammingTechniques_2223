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
        ListNode lista3 = new ListNode(0);
        lista3.next = new ListNode(0);
        ListNode wynikDzialania = lista3 ; 

        int wynik = 0;  
        int reszta = 0; 
        int przeniesienie =0;
    
        while (l1!=null || l2!=null )
        {
            int a1=0;
            int a2=0;
            if(l1 != null) {
                a1=l1.val;
                l1 = l1.next;
            }
            if(l2 != null) {
                a2=l2.val;
                l2 = l2.next;
            }
            wynik = a1 + a2 + przeniesienie;
            przeniesienie =0;
            if(wynik<=9){
                lista3.next = new ListNode(wynik);
                lista3=lista3.next;
            }
            else{
                przeniesienie = 1;
                reszta=wynik-10;
                lista3.next = new ListNode(reszta);
                 lista3=lista3.next;
            }
        }
        if (wynik >= 10)
             {
                  lista3.next = new ListNode(przeniesienie);
                  lista3=lista3.next;
             }
         return wynikDzialania.next;        
    }
}

