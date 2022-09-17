namespace LeetCode.Easy;

public class E58
{
    public int LengthOfLastWord(string s)
    {
        int sp = 1;
        for (int i = s.Length-1; i >= 0; i--)
        {
            if ((i == s.Length - 1 || s[i+1] ==' ') && s[i] == ' ')
            {
                sp++;
                continue;
            }
            if (s[i] == ' ')
                return s.Length-i-sp;
        }
        return s.Length-sp+1;
    }
}