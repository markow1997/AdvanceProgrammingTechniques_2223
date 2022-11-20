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
    ListNode* swapNodes(ListNode* head, int k) {
        ListNode* temp1 = head, *temp2 = head;
        
        for(int i=0; i < k-1; i++) {
            temp1 = temp1->next;
        } 
            
        ListNode* first = temp1;
        temp1 = temp1->next;
        while(temp1 != nullptr) {
            temp1 = temp1->next;
            temp2 = temp2->next;
        }

        int temp = first->val;
        first->val = temp2->val;
        temp2->val = temp;
        
        return head;
    }
};
