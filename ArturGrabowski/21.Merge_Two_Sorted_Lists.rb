# Definition for singly-linked list.
# class ListNode
#     attr_accessor :val, :next
#     def initialize(val = 0, _next = nil)
#         @val = val
#         @next = _next
#     end
# end
# @param {ListNode} list1
# @param {ListNode} list2
# @return {ListNode}
def merge_two_lists(list1, list2)
    if list1 == nil && list2 == nil
        return nil
    end

    head = ListNode.new()
    walkerResult = head
    walker1 = list1
    walker2 = list2
    
    while walker1 != nil && walker2 != nil
        if walker1.val <= walker2.val
            walkerResult.next = ListNode.new(walker1.val)
            walkerResult = walkerResult.next
            walker1 = walker1.next
        else
            walkerResult.next = ListNode.new(walker2.val)
            walkerResult = walkerResult.next
            walker2 = walker2.next
        end
    end

    while walker1 != nil
        walkerResult.next = ListNode.new(walker1.val)
        walker1 = walker1.next
        walkerResult = walkerResult.next
    end
    
    while walker2 != nil
        walkerResult.next = ListNode.new(walker2.val)
        walker2 = walker2.next
        walkerResult = walkerResult.next
    end

    return head.next
end
