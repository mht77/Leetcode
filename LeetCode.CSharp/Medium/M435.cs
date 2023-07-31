namespace LeetCode.Medium;

public class M435
{
    public int EraseOverlapIntervals(int[][] intervals)
    {
        Array.Sort(intervals, (ints, ints1) => ints[1] < ints1[1] ? -1 : 1);
        int count = 0;
        int end = intervals[0][1];

        for (var index = 1; index < intervals.Length; index++)
        {
            var interval = intervals[index];

            if (interval[0] < end)
                count++;
            else
                end = interval[1];
        }

        return count;
    }
}