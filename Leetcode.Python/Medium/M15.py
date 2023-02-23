from typing import List


class Solution:
    def threeSum(self, nums: List[int]) -> List[List[int]]:
        nums = sorted(nums)
        result = []
        for i in range(len(nums)):
            if i > 0 and nums[i] == nums[i-1]:
                continue
            start = i + 1
            end = len(nums) - 1
            while start < end:
                _sum = nums[i] + nums[start] + nums[end]
                if _sum > 0:
                    end -= 1
                elif _sum == 0:
                    result += [[nums[i], nums[start], nums[end]]]
                    while nums[start] == nums[start+1]:
                        start += 1
                        if start == end:
                            break
                    start += 1
                else:
                    start += 1
        return result
