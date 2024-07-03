namespace LeetCode.Problems;

public class Solution238
{
    public int[] ProductExceptSelf(int[] nums)
    {
        int[] result = new int[nums.Length];
        
        result[0] = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            result[i] = nums[i - 1] * result[i - 1];
        }

        var suffix = 1;
        for (int i = nums.Length - 2; i >= 0; i--)
        {
            suffix *= nums[i + 1];
            result[i] *= suffix;
        }

        return result;
    }
}