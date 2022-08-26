namespace LeetCode.Easy;

public class E383
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        foreach (var ch in ransomNote)
        {
            if (!magazine.Contains(ch))
                return false;
            var index = magazine.IndexOf(ch);
            magazine = magazine.Remove(index, 1);
        }
        return true;
    }
}