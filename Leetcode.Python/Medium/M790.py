class Solution:
    def numTilings(self, n: int) -> int:
        no_ways = [
            1,
            2,
            5
        ]

        if n < 3:
            return no_ways[n-1]

        for i in range(3, n):
            no_ways.append(2*no_ways[i-1]+no_ways[i-3])

        return no_ways[len(no_ways)-1] % (10**9 + 7)