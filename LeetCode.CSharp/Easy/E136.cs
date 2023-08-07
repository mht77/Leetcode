namespace LeetCode.Easy;

public class E136
{
    public int SingleNumber(int[] nums)
    {
        int res = 0;

        foreach (var num in nums)
        {
            res ^= num;
        }

        return res;
    }
}