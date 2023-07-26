namespace LeetCode.Medium;

public class M198
{
    public int Rob(int[] nums)
    {
        if (nums.Length == 1)
            return nums[0];
        
        if (nums.Length == 2)
            return nums[0] > nums[1] ? nums[0] : nums[1];

        List<int> sums = new List<int>
        {
            nums[0],
            nums[1],
            nums[2]+nums[0]
        };

        for (int i = 3; i < nums.Length; i++)
        {
            var first = sums[i - 3] + nums[i];
            var second = sums[i - 2] + nums[i];
            
            sums.Add(first > second ? first : second);
        }

        return sums[^2] > sums[^1] ? sums[^2] : sums[^1];
    }

}