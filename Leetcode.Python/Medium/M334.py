from typing import List


class Solution:
    def increasingTriplet(self, nums: List[int]) -> bool:
        if len(nums) < 3:
            return False

        first = nums[0]
        second = None
        for i in range(1, len(nums)):
            if second is None:
                if nums[i] > first:
                    second = nums[i]
                else:
                    first = nums[i]
            else:
                if nums[i] > second:
                    return True
                elif nums[i] < first:
                    first = nums[i]
                elif first < nums[i] < second:
                    second = nums[i]

        return False
