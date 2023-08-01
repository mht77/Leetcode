namespace LeetCode.Medium;

public class M1143
{
    public int LongestCommonSubsequence(string text1, string text2)
    {
        var dp = new int[text1.Length+1, text2.Length+1];
        
        for (int i = 1; i <= text1.Length; i++)
        {
            for (int j = 1; j <= text2.Length; j++)
            {
                var up = dp[i, j - 1];
                var left = dp[i - 1, j];
                dp[i, j] = Math.Max(up, left);

                if (text1[i-1] == text2[j-1])
                {
                    dp[i, j] = Math.Max(dp[i, j], dp[i-1, j-1] + 1);
                }
            }
        }

        return dp[text1.Length, text2.Length];
    }
}