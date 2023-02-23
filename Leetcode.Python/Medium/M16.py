from typing import List


class Solution:
    def threeSumClosest(self, nums: List[int], target: int) -> int:
        nums = sorted(nums)
        res = None
        for i in range(len(nums)):
            start = i + 1
            end = len(nums) - 1
            while start < end:
                _sum = nums[i] + nums[start] + nums[end]
                if target - _sum == 0:
                    return target
                if target - _sum > 0:
                    start += 1
                else:
                    end -= 1
                if (res and abs(target - _sum) < abs(res - target)) or not res:
                    res = _sum
        return res
