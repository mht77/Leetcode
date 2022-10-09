from typing import List


class Solution:
    def findMedianSortedArrays(self, nums1: List[int], nums2: List[int]) -> float:
        l1, l2 = len(nums1), len(nums2)
        if l1 > l2:
            return self.findMedianSortedArrays(nums2, nums1)
        s, e = 0, l1
        rm = (l1 + l2 + 1) // 2
        while s <= e:
            m = (s + e + 1) // 2
            left1 = m
            left2 = rm - m
            leftA = nums1[left1 - 1] if (left1 > 0) else float('-inf')
            leftB = nums2[left2 - 1] if (left2 > 0) else float('-inf')
            rightA = nums1[left1] if (left1 < l1) else float('inf')
            rightB = nums2[left2] if (left2 < l2) else float('inf')
            if leftA <= rightB and leftB <= rightA:
                if (l1 + l2) % 2 == 0:
                    return (max(leftA, leftB) + min(rightA, rightB)) / 2.0
                return max(leftA, leftB)
            if leftA > rightB:
                e = m - 1
            else:
                s = m + 1
