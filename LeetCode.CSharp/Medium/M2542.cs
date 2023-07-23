namespace LeetCode.Medium;

public class M2542
{
    public long MaxScore(int[] nums1, int[] nums2, int k)
    {
        int n = nums1.Length;
        
        List<(int, int)> list = new();
        for (int i = 0; i < n; i++)
        {
            list.Add((nums1[i], nums2[i]));
        }
        
        list.Sort((a, b) => b.Item2.CompareTo(a.Item2));

        PriorityQueue<int, int> queue = new();
        long sum = 0;
        for (int i = 0; i < k; i++)
        {
            sum += list[i].Item1;
            queue.Enqueue(list[i].Item1, list[i].Item1);
        }

        long res = sum * list[k - 1].Item2;
        
        for (int i = k; i < n; i++)
        {
            queue.Enqueue(list[i].Item1, list[i].Item1);
            sum += list[i].Item1;
            sum -= queue.Dequeue();
            res = Math.Max(res, sum * list[i].Item2);
        }

        return res;
    }
}