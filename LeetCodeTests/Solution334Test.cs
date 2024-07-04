namespace LeetCodeTests;

public class Solution334Test : LeetCode.Problems.Solution334
{
    [Theory]
    [InlineData(new [] {1,2,3,4,5}, true)]
    [InlineData(new [] {5,4,3,2,1}, false)]
    [InlineData(new [] {2,1,5,0,4,6}, true)]
    [InlineData(new [] {20,100,10,12,5,13}, true)]
    [InlineData(new [] {2,4,-2,-3}, false)]
    public void IncreasingTriplet_Test(int[] nums, bool expected)
    {
        var actual = IncreasingTriplet(nums);
        Assert.Equal(expected, actual);
    }
}