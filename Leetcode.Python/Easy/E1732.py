from typing import List


class Solution:
    def largestAltitude(self, gain: List[int]) -> int:
        sum = 0
        high = 0

        for i in gain:
            sum += i
            if high is None or sum > high:
                high = sum

        return high
