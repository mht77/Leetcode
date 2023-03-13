from typing import List


class Solution:

    def fourSum(self, nums: List[int], target: int) -> List[List[int]]:
        nums = sorted(nums)
        result = []
        for i in range(len(nums)):
            for j in range(i + 1, len(nums)):
                if i > 0 and nums[i] == nums[i - 1]:
                    continue
                if j > i + 1 and nums[j] == nums[j - 1]:
                    continue
                start = j + 1
                end = len(nums) - 1
                while start < end:
                    _sum = nums[i] + nums[j] + nums[start] + nums[end]
                    if _sum > target:
                        end -= 1
                    elif _sum == target:
                        result += [[nums[i], nums[j], nums[start], nums[end]]]
                        while nums[start] == nums[start + 1]:
                            start += 1
                            if start == end:
                                break
                        start += 1
                    else:
                        start += 1
        return result
