namespace LeetCode.Easy;

public class E643
{
    public double FindMaxAverage(int[] nums, int k)
    {
        double avg;
        int sum = 0;

        for (int i = 0; i < k; i++)
        {
            sum += nums[i];
        }

        avg = (double) sum / k;
        
        for (int i = k; i < nums.Length; i++)
        {
            sum += nums[i] - nums[i - k];
            
            if ((double)sum / k > avg)
                avg = (double)sum / k;
        }
        
        return avg;
    }
}