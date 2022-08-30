from typing import List


def searchInsert(nums: List[int], target: int) -> int:
    lower = 0
    upper = len(nums) - 1
    while True:
        mid = int((upper + lower) / 2)
        if nums[mid] == target:
            return mid
        if nums[mid] > target:
            upper = mid
        else:
            lower = mid
        if lower == upper or lower + 1 == upper:
            if target <= nums[lower]:
                return lower
            if target == nums[upper]:
                return upper
            if target > nums[upper]:
                return upper + 1
            return upper
