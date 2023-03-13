from typing import List


class Solution:
    def pacificAtlantic(self, heights: List[List[int]]) -> List[List[int]]:
        if not heights:
            return []
        m, n = len(heights), len(heights[0])
        pacific = [[False] * n for _ in range(m)]
        atlantic = [[False] * n for _ in range(m)]
        for i in range(m):
            self.dfs(heights, pacific, i, 0)
            self.dfs(heights, atlantic, i, n - 1)
        for i in range(n):
            self.dfs(heights, pacific, 0, i)
            self.dfs(heights, atlantic, m - 1, i)
        res = []
        for i in range(m):
            for j in range(n):
                if pacific[i][j] and atlantic[i][j]:
                    res.append([i, j])
        return res

    def dfs(self, heights, pacific, i, param):
        if pacific[i][param]:
            return
        pacific[i][param] = True
        for x, y in [[i + 1, param], [i - 1, param], [i, param + 1], [i, param - 1]]:
            if 0 <= x < len(heights) and 0 <= y < len(heights[0]) and heights[x][y] >= heights[i][param]:
                self.dfs(heights, pacific, x, y)
