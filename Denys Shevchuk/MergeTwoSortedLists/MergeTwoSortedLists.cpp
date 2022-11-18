/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     ListNode *next;
 *     ListNode() : val(0), next(nullptr) {}
 *     ListNode(int x) : val(x), next(nullptr) {}
 *     ListNode(int x, ListNode *next) : val(x), next(next) {}
 * };
 */
class Solution {
public:
    ListNode* mergeTwoLists(ListNode* head1, ListNode* head2) {
        ListNode* newHead = new ListNode();
        ListNode* pointer = newHead;
        if(head1 && head2)
        {
            if(head1->val > head2->val){
                newHead->val = head2->val;
                head2 = head2->next;
            }
            else
            {
                newHead->val = head1->val;
                head1 = head1->next;
            }
        }
        else if(!head1 && !head2){
            return nullptr;
            }
        else if(!head1 || !head2)
            return head1==nullptr ? head2 : head1;
        
        
        while(head1 && head2){
            if(head1->val > head2->val){
                ListNode* newValue = new ListNode(head2->val);
                pointer->next = newValue;
                pointer = newValue;
                head2 = head2->next;
            }
            else{
                ListNode* newValue = new ListNode(head1->val);
                pointer->next = newValue;
                pointer = newValue;
                head1 = head1->next;
            }
        }
        if(head1 && !head2){
            while(head1){
                ListNode* newValue = new ListNode(head1->val);
                pointer->next = newValue;
                pointer = newValue;
                head1 = head1->next;
            }
        }
        else if(!head1 && head2){
            while(head2){
                ListNode* newValue = new ListNode(head2->val);
                pointer->next = newValue;
                pointer = newValue;
                head2 = head2->next;
            }
        }
      return newHead;  
    }
};
