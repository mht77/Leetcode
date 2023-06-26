namespace LeetCode.Medium;

public class M1679
{
    public int MaxOperations(int[] nums, int k)
    {
        int res = 0;

        Array.Sort(nums);

        int start = 0;
        int end = nums.Length - 1;
        
        while (true)
        {
            if (start >= end)
                break;
            
            var sum = nums[start] + nums[end];
            
            if (sum == k)
            {
                res++;
                start++;
                end--;
            }
            else if (sum > k)
                end--;
            else
                start++;
            
        }

        return res;
    }
}