using System.Text;

namespace LeetCode.Medium;

public class M394
{
    public string DecodeString(string s)
    {
        var stack = new Stack<(int, StringBuilder)>();
        var sb = new StringBuilder();
        var num = 0;
        
        foreach (var c in s)
        {
            if (char.IsDigit(c))
            {
                num = num * 10 + (c - '0');
            }
            else if (c == '[')
            {
                stack.Push((num, sb));
                sb = new StringBuilder();
                num = 0;
            }
            else if (c == ']')
            {
                var (n, prev) = stack.Pop();
                var tmp = sb;
                sb = prev;
                while (n > 0)
                {
                    sb.Append(tmp);
                    n--;
                }
            }
            else
            {
                sb.Append(c);
            }
        }

        return sb.ToString();
    }
}