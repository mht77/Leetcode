namespace LeetCode.Easy;

public class E1
{
    public int[] TwoSum(int[] nums, int target) {
        for (int i=0;i<nums.Length;i++){
            for (int j=i+1;j<nums.Length;j++){
                if (nums[i] + nums[j] == target)
                {
                    int[] res = new int[2];
                    res[0] = i;
                    res[1] = j;
                    return res;
                }
            }
        }
        return null!;
    }
}