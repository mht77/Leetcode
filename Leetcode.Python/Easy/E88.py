from typing import List


class Solution:
    def merge(self, nums1: List[int], m: int, nums2: List[int], n: int) -> None:
        if n == 0:
            return
        i = 0
        j = 0
        while i < m + n:
            if nums1[i] > nums2[j]:
                nums1.insert(i, nums2[j])
                nums1.pop(len(nums1)-1)
                j += 1
            elif nums1[i] == 0 and i >= m + j:
                nums1[i] = nums2[j]
                j += 1
            if j == len(nums2):
                break
            i += 1
