from typing import List


class Solution:
    def orangesRotting(self, grid: List[List[int]]) -> int:
        m = len(grid)
        n = len(grid[0])
        directions = [(0, 1), (1, 0), (0, -1), (-1, 0)]
        rottens = []
        reserves = []
        freshers = []
        res = -1
        visited = set()

        for i in range(m):
            for j in range(n):
                if grid[i][j] == 2:
                    rottens.append((i, j))
                if grid[i][j] == 1:
                    freshers.append((i, j))

        while len(rottens) > 0 and len(rottens) > 0:
            current = rottens.pop(0)
            visited.add(current)

            for d in directions:
                adj = (current[0]+d[0], current[1]+d[1])

                if adj[0] > m-1 or adj[0] < 0 or adj[1] > n-1 or adj[1] < 0:
                    continue

                if adj not in visited and grid[adj[0]][adj[1]] == 1:
                    freshers.remove(adj)
                    grid[adj[0]][adj[1]] = 2
                    reserves.append(adj)

            if len(rottens) == 0:
                rottens.extend(reserves)
                reserves.clear()
                res += 1

        if len(freshers) > 0:
            return -1

        return 0 if res == -1 else res