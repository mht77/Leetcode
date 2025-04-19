from typing import List


class Solution:
    def searchRange(self, nums: List[int], target: int) -> List[int]:
        first = self.binary_search(nums, target)
        l, h = first, first

        while l != -1:
            l_m = self.binary_search(nums[:l], target)

            if l_m == -1:
                break

            l = l_m

        while h != -1:
            h_m = self.binary_search(nums[h:], target)

            if h_m == -1 or h_m == 0:
                break

            h += h_m

        if l == -1 and h != -1:
            l = h
        elif h == -1 and l != -1:
            h = l

        return [l, h]


    def binary_search(self, nums: List[int], target: int):
        low = 0
        high = len(nums)
        while low < high:
            mid = (high + low) // 2
            if nums[mid] == target:
                return mid
            if target > nums[mid]:
                low = mid
            else:
                high = mid

            if (high + low) // 2 == mid:
                break

        return -1
