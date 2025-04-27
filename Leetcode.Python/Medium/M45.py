from typing import List


class Solution:
    def jump(self, nums: List[int]) -> int:
        count = 0
        mx = 0
        end = 0

        for i, n in enumerate(nums):
            if i == len(nums) - 1:
                break

            mx = max(mx, n+i)

            if i == end:
                count += 1
                end = mx

        return count