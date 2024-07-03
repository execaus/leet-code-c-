namespace LeetCodeTests;

public class Solution238Test : LeetCode.Problems.Solution238
{
    [Theory]
    [InlineData(new [] {1,2,3,4}, new [] {24,12,8,6})]
    [InlineData(new [] {-1,1,0,-3,3}, new [] {0,0,9,0,0})]
    public void ProductExceptSelf_Test(int[] nums, int[] expected)
    {
        var actual = ProductExceptSelf(nums);
        Assert.Equal(expected, actual);
    }
}