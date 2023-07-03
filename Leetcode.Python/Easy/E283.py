from typing import List


class Solution:
    def moveZeroes(self, nums: List[int]) -> None:
        i = 0
        index = 0
        while i < len(nums):
            if nums[index] == 0:
                nums.pop(index)
                nums.append(0)
                index -= 1

            i += 1
            index += 1
