import collections
from typing import List


class Solution:
    def nearestExit(self, maze: List[List[str]], entrance: List[int]) -> int:

        def bfs(x, y):
            q = collections.deque()
            q.append((x, y, 0))
            visited[x][y] = True
            while q:
                x, y, step = q.popleft()
                if not (x == entrance[0] and y == entrance[1]):
                    if x == 0 or y == 0 or x == m - 1 or y == n - 1:
                        return step
                for dx, dy in [(0, 1), (1, 0), (0, -1), (-1, 0)]:
                    nx, ny = x + dx, y + dy
                    if 0 <= nx < m and 0 <= ny < n and maze[nx][ny] == '.' and not visited[nx][ny]:
                        visited[nx][ny] = True
                        q.append((nx, ny, step + 1))
            return -1

        m, n = len(maze), len(maze[0])
        visited = [[False] * n for _ in range(m)]
        return bfs(entrance[0], entrance[1])