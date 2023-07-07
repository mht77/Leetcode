namespace LeetCode.Medium;

public class M1657
{
    public bool CloseStrings(string word1, string word2)
    {
        Dictionary<char, int> lettersW1 = new Dictionary<char, int>();
        Dictionary<char, int> lettersW2 = new Dictionary<char, int>();

        foreach (var l in word1)
        {
            if (lettersW1.ContainsKey(l))
                lettersW1[l]++;
            else
                lettersW1.Add(l, 1);
        }

        foreach (var l in word2)
        {
            if (lettersW2.ContainsKey(l))
                lettersW2[l]++;
            else
                lettersW2.Add(l, 1);
        }

        bool res = true;

        var w1 = lettersW1.Values.ToList();
        w1.Sort();

        var w2 = lettersW2.Values.ToList();
        w2.Sort();

        if (w1.Count != w2.Count)
            return false;

        foreach (var item in lettersW1.Keys)
        {
            if (!lettersW2.ContainsKey(item))
                return false;
        }

        for (int i = 0; i < w1.Count; i++)
        {
            if (w1[i] != w2[i])
                res = false;
        }

        return res;
    }
}