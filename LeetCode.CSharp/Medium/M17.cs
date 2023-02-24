namespace LeetCode.Medium;

public class M17
{
    private readonly Dictionary<char, string> map = new() {
    {'2', "abc"},
    {'3', "def"},
    {'4', "ghi"},
    {'5', "jkl"},
    {'6', "mno"},
    {'7', "pqrs"},
    {'8', "tuv"},
    {'9', "wxyz"}
    };
    public IList<string> LetterCombinations(string digits)
    {
        List<string> res = new List<string>();
        
        if (string.IsNullOrEmpty(digits))
            return res;

        if (digits.Length == 1)
        {
            foreach (var chr in map[digits[0]])
            {
                res.Add(chr.ToString());
            }

            return res;
        }

        var rest = LetterCombinations(digits[1..]);

        for (int i = 0; i < map[digits[0]].Length; i++)
        {
            foreach (var item in rest)
            {
                res.Add(item.Insert(0, map[digits[0]][i].ToString()));
            }
        }
        return res;
    }
}