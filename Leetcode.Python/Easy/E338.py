from typing import List


class Solution:
    def countBits(self, n: int) -> List[int]:
        res = [0, 1]

        while len(res) <= n:
            res += [i + 1 for i in res]

        return res[:n + 1]