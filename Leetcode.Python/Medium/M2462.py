import queue
from typing import List


class Solution:
    def totalCost(self, costs: List[int], k: int, candidates: int) -> int:
        q = queue.PriorityQueue(maxsize=candidates*2)
        n = len(costs)-1
        s = 0
        e = n
        res = 0

        for i in range(candidates):
            cost = costs[i]
            q.put((cost, i))
            s = i

            if q.full() or e-1 == s and e != n:
                break

            cost = costs[n-i]
            q.put((cost, n-i))
            e = n-i

            if q.full() or s+1==e:
                break


        for _ in range(k):
            cost, index = q.get()
            res += cost
            if index <= s+1 < e:
                s += 1
                q.put((costs[s], s))
            elif index >= e-1 > s:
                e -= 1
                q.put((costs[e], e))

        return res