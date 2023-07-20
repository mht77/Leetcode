from typing import List


class Solution:
    def calcEquation(self, equations: List[List[str]], values: List[float], queries: List[List[str]]) -> List[float]:
        graph = {}
        res = []

        for i in range(len(equations)):
            node = graph.get(equations[i][0])
            if node:
                graph[equations[i][0]].append((equations[i][1], values[i], equations[i][0]))
            else:
                graph[equations[i][0]] = [(equations[i][1], values[i], equations[i][0])]

            other_node = graph.get(equations[i][1])
            if other_node:
                graph[equations[i][1]].append((equations[i][0], 1/values[i], equations[i][1]))
            else:
                graph[equations[i][1]] = [(equations[i][0], 1/values[i], equations[i][1])]


        for q in queries:

            if q[0] not in graph or q[1] not in graph:
                res.append(-1.0)
                continue

            if q[0] == q[1]:
                res.append(1.0)
                continue

            connected_nodes = list(graph[q[0]])
            paths = {q[0]: 1}
            visited = set()
            visited.add(q[0])
            found = False

            while len(connected_nodes) > 0:
                nt = connected_nodes.pop()
                last = nt[2]

                if last not in paths:
                    paths[nt[0]] = nt[1]
                else:
                    paths[nt[0]] = nt[1] * paths[last]

                if nt[0] == q[1]:
                    res.append(paths[nt[0]])
                    found = True
                    break

                visited.add(nt[0])

                for node in graph[nt[0]]:
                    if node[0] not in visited:
                        connected_nodes.append(node)

            if not found:
                res.append(-1.0)

        return res

