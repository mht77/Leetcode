namespace LeetCode.Easy;

public class E605
{
    public bool CanPlaceFlowers(int[] flowerbed, int n)
    {
        if (flowerbed.Length == 1)
        {
            if (n == 0) return true;
            return flowerbed[0] == 0;
        }
        
        var i = 0;
        
        while (i < flowerbed.Length)
        {
            if (i == 0 && flowerbed[0] == 0 && flowerbed[1] == 0)
            {
                flowerbed[0] = 1;
                n--;
                i++;
            }
            if (i == flowerbed.Length - 1 && flowerbed[i - 1] == 0 && flowerbed[i] == 0)
            {
                n--;
                i++;
            }
            if (i > 0 && i < flowerbed.Length-2)
            {
                if (flowerbed[i - 1] == 0 && flowerbed[i + 1] == 0 && flowerbed[i] == 0)
                {
                    n--;
                    flowerbed[i] = 1;
                    i++;
                }
            }

            i++;
        }

        return n<=0;
    }
}