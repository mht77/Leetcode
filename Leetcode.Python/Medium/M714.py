from typing import List


class Solution:
    def maxProfit(self, prices: List[int], fee: int) -> int:
        dp = [[], []] # 0 -> have stock, 1 -> don't have
        dp[0].append(-prices[0])
        dp[1].append(0)

        for i in range(1, len(prices)):
            dp[0].append(max(dp[1][i-1] - prices[i], dp[0][i-1]))
            dp[1].append(max(prices[i]+dp[0][i-1]-fee, dp[1][i-1]))

        return dp[-1][-1]