from typing import List


class Solution:
    def findMinArrowShots(self, points: List[List[int]]) -> int:
        points = sorted(points)
        count = 1
        end = points[0][1]

        for i in range(1, len(points)):
            if points[i][0] > end:
                count += 1
                end = points[i][1]
            elif points[i][1] < end:
                end = points[i][1]

        return count

