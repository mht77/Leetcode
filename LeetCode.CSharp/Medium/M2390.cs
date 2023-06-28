using System.Text;

namespace LeetCode.Medium;

public class M2390
{
    public string RemoveStars(string s)
    {
        StringBuilder res = new StringBuilder("");

        foreach (var chr in s)
        {
            if (chr == '*')
            {
                res.Remove(res.Length - 1, 1);
            }
            else
            {
                res.Append(chr);
            }
        }

        return res.ToString();
    }
}