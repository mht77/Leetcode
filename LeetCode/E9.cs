namespace LeetCode;

public class E9
{
    public bool IsPalindrome(int x)
    {
        var str = x.ToString();
        while (str.Length > 0)
        {
            if (str.Length == 1)
                break;
            if (str[0] != str[^1])
                return false;
            str = str.Remove(0, 1);
            str = str.Remove(str.Length - 1, 1);
        }
        return true;
    }
}