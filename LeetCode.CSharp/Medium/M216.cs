namespace LeetCode.Medium;

public class M216
{
    public IList<IList<int>> CombinationSum3(int k, int n)
    {
        return Find(k, n , 1);
    }

    private IList<IList<int>> Find(int k, int n, int start)
    {
        var res = new List<IList<int>>();

        if (k == 0)
            return res;

        for (int i = start; i < 10; i++)
        {
            if (n - i == 0 && k == 1)
            {
                res.Add(new List<int> {i});
                return res;
            }

            if (n - i == 0 && k > 1)
                return res;
            
            if (n - i > 0)
            {
                var subRes = Find(k - 1, n - i, i + 1);
                foreach (var sub in subRes)
                {
                    var l = new List<int>(sub) {i};
                    res.Add(l);
                }
            }
        }

        return res;
    }
}