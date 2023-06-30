namespace LeetCode.Easy;

public class E1071
{
    public string GcdOfStrings(string str1, string str2)
    {
        if (str1 == str2)
            return str1;
        
        List<string> t1 = new List<string>();
        List<string> t2 = new List<string>();

        for (int index = 0; index < str1.Length-1; index++)
        {
            if (str1.Length % (index + 1) != 0)
                continue;
            
            var t = str1.Substring(0, index+1);
            var tempRes = "";

            while (tempRes.Length < str1.Length)
            {
                tempRes += t;
            }

            if (tempRes == str1)
            {
                t1.Add(t);
            }
        }
        
        for (int index = 0; index < str2.Length-1; index++)
        {
            if (str2.Length % (index + 1) != 0)
                continue;
            
            var t = str2.Substring(0, index+1);
            var tempRes = "";

            while (tempRes.Length < str2.Length)
            {
                tempRes += t;
            }

            if (tempRes == str2)
            {
                t2.Add(t);
            }
        }

        if (t1.Contains(str2))
            return str2;

        if (t2.Contains(str1))
            return str1;

        string res = "";

        foreach (var key in t1)
        {
            if (t2.Contains(key) && key.Length > res.Length)
                res = key;
        }

        return res;
    }
}