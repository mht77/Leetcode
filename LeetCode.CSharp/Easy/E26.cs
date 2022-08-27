namespace LeetCode.Easy;

public class E26
{
    public int RemoveDuplicates(int[] nums)
    {
        int duplicates = 0;
        for (int i = 0; i < nums.Length-1-duplicates; i++)
        {
            if (nums.Length-1==i)
                break;
            if (nums[i] != nums[i + 1]) continue;
            duplicates++;
            for (int j = i+1; j < nums.Length-duplicates; j++)
            {
                (nums[j + 1], nums[j]) = (nums[j], nums[j + 1]);
            }
            i--;
        }
        return nums.Length - duplicates;
    }
}