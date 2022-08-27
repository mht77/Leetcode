from typing import Optional


# noinspection PyShadowingBuiltins
class ListNode:
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next


class Solution:

    def mergeTwoLists(self, list1: Optional[ListNode], list2: Optional[ListNode]) -> Optional[ListNode]:
        if not list1 and list2:
            return list2
        if not list2 and list1:
            return list1
        if not list1 and not list2:
            return list1
        r = ListNode()
        if list1.val < list2.val:
            r.val = list1.val
            list1 = list1.next
        else:
            r.val = list2.val
            list2 = list2.next
        if not list1:
            r.next = list2
        elif not list2:
            r.next = list1
        else:
            r.next = self.mergeTwoLists(list1, list2)
        return r
