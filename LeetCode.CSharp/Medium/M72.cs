namespace LeetCode.Medium;

public class M72
{
    public int MinDistance(string word1, string word2)
    {
        var dis = new int[word1.Length+1, word2.Length+1];
        for (int i = 0; i <= word1.Length; i++)
        {
            for (int j = 0; j <= word2.Length; j++)
            {
                if (i == 0)
                    dis[i, j] = j;
                else if (j == 0)
                    dis[i, j] = i;
                else if (word1[i-1] == word2[j-1])
                    dis[i, j] = dis[i - 1, j - 1];
                else
                    dis[i, j] = 1 + Math.Min(dis[i, j - 1], Math.Min(dis[i - 1, j], dis[i - 1, j - 1]));
            }
        }
        return dis[word1.Length, word2.Length];
    }
}

