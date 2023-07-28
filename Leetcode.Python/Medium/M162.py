from typing import List


class Solution:
    def findPeakElement(self, nums: List[int]) -> int:
        start = 0
        end = len(nums) - 1

        if len(nums) == 1:
            return 0
        
        if nums[start] > nums[start+1]:
            return start
        
        if nums[end] > nums[end-1]:
            return end


        while start < end:

            index = (end + start) // 2

            if nums[index] > nums[index-1] and nums[index] > nums[index+1]:
                return index
            
            if nums[index] > nums[index-1]:
                start = index
            
            if nums[index] < nums[index-1]:
                end = index