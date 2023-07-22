namespace LeetCode.Medium;

public class M2336
{

    private readonly PriorityQueue<int, int> numbers = new();
    private readonly HashSet<int> removed = new();

    public M2336()
    {
        for (int i = 1; i < 1001; i++)
        {
            numbers.Enqueue(i,i);
        }
    }
    
    public int PopSmallest()
    {
        var r = numbers.Dequeue();
        removed.Add(r);
        return r;
    }
    
    public void AddBack(int num)
    {
        if (!removed.Contains(num)) return;
        numbers.Enqueue(num, num);
        removed.Remove(num);
    }
}