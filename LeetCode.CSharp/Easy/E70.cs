namespace LeetCode.Easy;

public class E70
{
    public int ClimbStairs(int n)
    {
        if (n is 1 or 2)
            return n;
        List<int> ways = new List<int> {1, 2};
        for (int i = 2; i < n; i++)
        {
            ways.Add(ways[i-1] + ways[i-2]);
        }

        return ways[^1];
        
        // recursice (not efficent)
        // if (n == 2 || n == 1)
        //     return n;
        // return ClimbStairs(n - 1) + ClimbStairs(n-2);
    }
}