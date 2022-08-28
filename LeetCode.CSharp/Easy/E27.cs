namespace LeetCode.Easy;

public class E27
{
    public int RemoveElement(int[] nums, int val)
    {
        int removed = 0;
        for (int i = 0; i < nums.Length-removed; i++)
        {
            if (nums[i] == val)
            {
                (nums[i], nums[nums.Length-1-removed]) = (nums[nums.Length-1-removed], nums[i]);
                removed++;
                i--;
            }
        }
        return nums.Length-removed;
    }
}