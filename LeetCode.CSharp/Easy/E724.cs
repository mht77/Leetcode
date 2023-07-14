namespace LeetCode.Easy;

public class E724
{
    public int PivotIndex(int[] nums)
    {
        if (nums.Length == 1)
            return 0;
        
        int index = 1;
        int sumRight = 0;
        int sumLeft = 0;

        for (var i=1; i < nums.Length; i++)
        {
            var num = nums[i];
            sumRight += num;
        }

        while (sumLeft != sumRight)
        {
            sumLeft += nums[index-1];
            
            sumRight -= nums[index];
            
            index++;

            if (index > nums.Length-1)
                break;
            
        }

        return sumLeft == sumRight ? index-1 : -1;
    }
}