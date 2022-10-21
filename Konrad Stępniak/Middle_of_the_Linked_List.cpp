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
    ListNode* middleNode(ListNode* head) {
        int counter=0;
        ListNode* temp=head;

        while (temp!=nullptr)
        {
            counter++;
            temp=temp->next;
        }
        //cout<<"no. "<<counter;

        int mid=ceil(counter/2);
        temp=head;
        for (counter=0; counter<mid; counter++)
        {
            temp=temp->next;
        }
        //cout<<temp->val;
        return temp;
    }
};