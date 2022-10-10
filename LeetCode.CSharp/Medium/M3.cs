namespace LeetCode.Medium;

public class M3
{
    public int LengthOfLongestSubstring(string s)
    {
        int res = 0;
        int cut = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s.Substring(cut, i-cut).Contains(s[i]))
            {
                cut++;
                i--;
            }
            res = Math.Max(res, i-cut + 1);
        }
        return res;
    }
}