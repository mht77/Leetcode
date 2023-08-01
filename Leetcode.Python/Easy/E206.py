from typing import Optional


class ListNode:
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next

class Solution:
    def reverseList(self, head: Optional[ListNode]) -> Optional[ListNode]:
        nodes = []

        while head:
            nodes.append(head.val)
            head = head.next

        res = None
        nxt = None
        while len(nodes) > 0:
            if not res:
                res = ListNode(nodes.pop())
                nxt = res
            else:
                nxt.next = ListNode(nodes.pop())
                nxt = nxt.next

        return res