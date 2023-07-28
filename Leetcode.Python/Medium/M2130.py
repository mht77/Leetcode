from typing import Optional


class ListNode:
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next
        
class Solution:
    def pairSum(self, head: Optional[ListNode]) -> int:
        m = None

        stack = []

        node = head
        while node != None:
            stack.append(node)
            node = node.next

        n = 0
        l = len(stack)
        while n < l / 2:
            end = stack.pop()

            if not m or head.val + end.val > m:
                m = head.val + end.val
            
            head = head.next
            n += 1

        return m