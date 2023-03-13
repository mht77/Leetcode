from typing import Optional


class ListNode:
    # Definition for singly-linked list.
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next
class Solution:
    def removeNthFromEnd(self, head: Optional[ListNode], n: int) -> Optional[ListNode]:
        start = head
        end = head.next
        while n > 0:
            if end:
                end = end.next
            else:
                return head.next
            n -= 1
        while True:
            if end is None:
                if not start.next:
                    return None
                start.next = start.next.next
                break
            start = start.next
            end = end.next
        return head
