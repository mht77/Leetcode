import heapq
from collections import defaultdict
from typing import List


class Solution:
    def __init__(self):
        self.graph = defaultdict(dict)

    def findTheCity(self, n: int, edges: List[List[int]], distanceThreshold: int) -> int:
        self.create_graph(edges, n)
        res = -1
        v = ''
        for vertex in sorted(self.graph, key=lambda x: int(x)):
            distances = {vertex: float('infinity') for vertex in self.graph}
            distances[vertex] = 0

            pq = [(0, vertex)]
            while len(pq) > 0:
                current_distance, current_vertex = heapq.heappop(pq)

                if current_distance > distances[current_vertex]:
                    continue

                for neighbor, weight in self.graph[current_vertex].items():
                    distance = current_distance + weight

                    if distance < distances[neighbor]:
                        distances[neighbor] = distance
                        heapq.heappush(pq, (distance, neighbor))
            c = 0
            for d in distances:
                if distances[d] <= distanceThreshold and d is not vertex:
                    c += 1
            if c <= res or res == -1:
                res = c
                v = vertex
        return int(v)

    def create_graph(self, edges, n):
        for edge in edges:
            self.graph[str(edge[0])].update({str(edge[1]): edge[2]})
            self.graph[str(edge[1])].update({str(edge[0]): edge[2]})
        while len(self.graph) < n:
            for i in range(n):
                if str(i) not in self.graph:
                    self.graph[str(i)] = {}
                    break
