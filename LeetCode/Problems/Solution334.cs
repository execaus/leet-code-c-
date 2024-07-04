namespace LeetCode.Problems;

public class Solution334
{
    public bool IncreasingTriplet(int[] nums) {
        if (nums.Length < 3)
        {
            return false;
        }

        int a = int.MaxValue, b = int.MaxValue;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] < a)
            {
                a = nums[i];
            }
            
            if (nums[i] > a && nums[i] < b)
            {
                b = nums[i];
            }

            if (nums[i] > b)
            {
                return true;
            }
        }

        return false;
    }
}
 