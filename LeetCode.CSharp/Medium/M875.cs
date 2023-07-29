namespace LeetCode.Medium;

public class M875
{
    public int MinEatingSpeed(int[] piles, int h)
    {
        if (piles.Length == 1)
        {
            var div = piles[0] / h;

            if (piles[0] % h > 0)
                div++;

            return div;
        }
        
        Array.Sort(piles);
        int start = 0;
        int end = piles[^1];
        int res = piles[^1];

        while (start < end)
        {
            var mid = (start + end) / 2;
            
            if (start==mid || end==mid)
            {
                if (start != 0)
                    if (IsOk(h, piles, start))
                        res = start;
                break;
            }
            
            if (IsOk(h, piles, mid))
            {
                end = mid;
                res = mid;
            }
            else
                start = mid;
        }
        
        return res;
    }

    private bool IsOk(int h, int[] piles, int num)
    {
        long count = 0;

        foreach (var pile in piles)
        {
            count += pile / num;

            if (pile % num > 0)
                count++;
        }

        return count <= h;
    }
}