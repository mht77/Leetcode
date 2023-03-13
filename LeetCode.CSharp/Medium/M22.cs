namespace LeetCode.Medium;

public class M22
{

    public IList<string> GenerateParenthesis(int n)
    {
        var res = new List<string>();
        var st = new Stack<(string, int, int)>();
        
        st.Push(("(", 1, 0));

        while (st.Count > 0)
        {
            var next = st.Pop();
            
            if (next.Item2 + next.Item3 == n * 2)
                res.Add(next.Item1);
            if (next.Item2 < n)
                st.Push((next.Item1 + '(', next.Item2 + 1, next.Item3));
            if (next.Item3 < n && next.Item3 < next.Item2)
                st.Push((next.Item1 + ')', next.Item2, next.Item3 + 1));
        }
        
        return res;
    }
}