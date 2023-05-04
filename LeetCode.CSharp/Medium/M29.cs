namespace LeetCode.Medium;

public class M29
{
    public int Divide(int dividend, int divisor)
    {
        if (dividend == Int32.MinValue && divisor == -1)
            return Int32.MaxValue;
        if (dividend == Int32.MinValue && divisor == 1)
            return Int32.MinValue;
        if (dividend == Int32.MaxValue && divisor == 1)
            return Int32.MaxValue;
        if (dividend == Int32.MaxValue && divisor == -1)
            return Int32.MinValue + 1;
        if (dividend == Int32.MinValue && divisor == Int32.MinValue)
            return 1;
        if (divisor == Int32.MinValue)
            return 0;
        if (dividend == 0)
            return 0;
        if (divisor == 1)
            return dividend;
        if (divisor == -1)
            return 0 - dividend;

        bool neg = false;
        long divid = dividend;
        if (divid < 0)
        {
            divid = 0 - divid;
            neg = !neg;
        }

        if (divisor < 0)
        {
            divisor = 0 - divisor;
            neg = !neg;
        }

        long res = 0;
        long div = divisor;
        while (div <= divid)
        {
            res++;
            if (div + divisor > divid)
                break;
            if (div + divisor == divid)
            {
                res++;
                break;
            }

            div += divisor;
        }

        var strictRes = res > Int32.MaxValue && !neg ? Int32.MaxValue : res > Int32.MaxValue && neg ? Int32.MinValue : Convert.ToInt32(res);
        return neg ? 0 - strictRes : strictRes;
    }
}