namespace LeetCode.Medium;

public class M7
{
    public int Reverse(int x)
    {
        long res = 0;
        var neg = x < 0;
        x = neg ? -x : x;
        int i = x.ToString().Length-1;
        while (x > 0)
        {
            res += x % 10 * (long) Math.Pow(10, i);
            i--;
            x /=10;
        }

        if (res > Int32.MaxValue || res < Int32.MinValue)
            return 0;
        return neg ? (int)-res : (int)res;
    }
}