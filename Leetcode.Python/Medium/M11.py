from typing import List


class Solution:
    def maxArea(self, height: List[int]) -> int:
        res = 0
        end = len(height) - 1
        start = 0
        while end > start:
            area = min(height[end], height[start]) * (end - start)
            if area > res:
                res = area
            if height[end] > height[start]:
                start += 1
            else:
                end -= 1
        return res

