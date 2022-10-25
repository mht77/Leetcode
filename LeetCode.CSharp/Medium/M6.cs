namespace LeetCode.Medium;

public class M6
{
    public string Convert(string s, int numRows)
    {
        if (numRows == 1)
            return s;
        string res = "";
        for (int k = 0; k < numRows; k++)
        {
            int j = 0;
            while (true)
            {
                var i = (numRows - 1) * 2 * j + k;
                if (i >= s.Length)
                    break;
                res += s[i];
                if (k != 0 && k != numRows - 1)
                {
                    var after = i + (numRows-k-1)*2;
                    if (after < s.Length)
                        res += s[after];
                }
                j++;
            }
        }

        return res;
    }
}