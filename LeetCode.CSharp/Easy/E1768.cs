namespace LeetCode.Easy;

public class E1768
{
    public string MergeAlternately(string word1, string word2)
    {
        string res = word1[0].ToString();
        bool second = true;

        int i = 0;
        
        while (true)
        {
            if (i == word1.Length)
            {
                res += word2.Substring(i);
                break;
            }

            if (i == word2.Length)
            {
                res += word1.Substring(i);
                break;
            }
            
            var chr = second ? word2[i] : word1[i];

            if (second)
                i++;
            
            second = !second;
            
            res = res.Insert(res.Length, chr.ToString());
            
        }

        return res;
    }
}