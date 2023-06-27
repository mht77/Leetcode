from typing import List


class Solution:
    def findDifference(self, nums1: List[int], nums2: List[int]) -> List[List[int]]:
        n1 = set(nums1)
        n2 = set(nums2)

        d1 = []
        d2 = []

        for num in n1:
            if num not in n2:
                d1.append(num)

        for num in n2:
            if num not in n1:
                d2.append(num)

        return [d1, d2]
