from typing import List


class Solution:
    def equalPairs(self, grid: List[List[int]]) -> int:
        rows = {}
        cols = {}

        for i in range(len(grid)):
            rows[i] = grid[i]

        for j in range(len(grid)):
            cols[j] = [x[j] for x in grid]

        count = 0

        for r in rows.values():
            for c in cols.values():
                if c == r:
                    count += 1

        return count