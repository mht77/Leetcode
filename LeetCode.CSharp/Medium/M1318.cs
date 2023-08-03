namespace LeetCode.Medium;

public class M1318
{
    public int MinFlips(int a, int b, int c)
    {
        int res = 0;

        var aBits = ConvertToBits(a);
        var bBits = ConvertToBits(b);
        var cBits = ConvertToBits(c);

        int maxSize = Math.Max(Math.Max(aBits.Count, bBits.Count), cBits.Count);

        aBits = IncreaseSize(aBits, maxSize);
        bBits = IncreaseSize(bBits, maxSize);
        cBits = IncreaseSize(cBits, maxSize);

        for (int i = 0; i < aBits.Count; i++)
        {
            if (cBits[i] && !aBits[i] && !bBits[i])
                res++;

            if (!cBits[i] && aBits[i] && bBits[i])
                res += 2; 
            else if (!cBits[i] && (aBits[i] || bBits[i]))
                res++;
        }

        return res;
    }

    private List<bool> ConvertToBits(int number)
    {
        var res = new List<bool>();

        while (number > 1)
        {
            res.Insert(0 ,number % 2 == 1);
            number /= 2;
        }
        res.Insert(0 ,number==1);

        return res;
    }

    private List<bool> IncreaseSize(List<bool> number, int size)
    {
        while (number.Count < size)
        {
            number.Insert(0, false);
        }

        return number;
    }
}