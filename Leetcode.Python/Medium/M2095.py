from typing import Optional


class ListNode:
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next


class Solution:
    def deleteMiddle(self, head: Optional[ListNode]) -> Optional[ListNode]:
        size = 1
        cp = head.next

        while cp:
            cp = cp.next
            size += 1

        mid = int(size / 2)

        if mid == 0:
            return None

        nx = head.next
        hd = head

        while mid > 0:
            mid -= 1
            if mid == 0:
                if hd.next:
                    hd.next = hd.next.next

            nx = nx.next
            hd = hd.next

        return head

s = Solution()
s.deleteMiddle(ListNode(1))
