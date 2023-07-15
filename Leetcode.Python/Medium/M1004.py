from typing import List


class Solution:
    def longestOnes(self, nums: List[int], k: int) -> int:
        m = nums[0] + k
        start = 0
        end = 1
        no_zeros = 1 if nums[start] == 0 else 0

        while end < len(nums):
            if nums[end] == 0:
                no_zeros += 1

            if no_zeros > k:
                start += 1
                while nums[start-1] == 1:
                    start += 1
                no_zeros -= 1
            else:
                if end - start + 1 > m:
                    m = end - start + 1
            end += 1

        return m
