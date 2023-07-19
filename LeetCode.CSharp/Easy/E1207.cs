namespace LeetCode.Easy;

public class E1207
{
    public bool UniqueOccurrences(int[] arr)
    {
        var numbers = new Dictionary<int, int>();
        var occurrences = new HashSet<int>();

        foreach (var number in arr)
        {
            if (numbers.ContainsKey(number))
                numbers[number]++;
            else
                numbers.Add(number, 1);
        }

        foreach (var occurrence in numbers.Values)
        {
            if (occurrences.Contains(occurrence))
                return false;
            occurrences.Add(occurrence);
        }
        
        return true;
    }
}