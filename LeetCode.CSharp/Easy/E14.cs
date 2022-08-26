namespace LeetCode.Easy;

public class E14
{
    public string LongestCommonPrefix(string[] strs)
    {
        string res = "";
        for (var index = 0; index < strs[0].Length; index++)
        {
            var chr = strs[0][index];
            bool r = false;
            for (int i = 1; i < strs.Length; i++)
            {
                if (index > strs[i].Length -1 )
                {
                    r = false;
                    break;
                }
                if (strs[i][index] != chr)
                {
                    r = false;
                    break;
                }
                if (i != strs.Length - 1) continue;
                r = true;
                res = res.Insert(res.Length, chr.ToString());
            }
            if (!r)
                break;
        }

        if (strs.Length == 1)
            return strs[0];
        return res;
    }
}