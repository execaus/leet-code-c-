namespace LeetCodeTests;

public class Solution605Test : LeetCode.Problems.Solution605
{
    [Theory]
    [InlineData(new [] {1,0,0,0,1}, 1, true)]
    [InlineData(new [] {1,0,0,0,1}, 2, false)]
    [InlineData(new [] {1,0,0,0,0,1}, 2, false)]
    [InlineData(new [] {0,0,1,0,1}, 1, true)]
    [InlineData(new [] {0,0,1,0,0}, 1, true)]
    [InlineData(new [] {0,0,0,0,0,1,0,0}, 0, true)]
    public void CanPlaceFlowers_Test(int[] flowerbed, int n, bool expected)
    {
        var actual = CanPlaceFlowers(flowerbed, n);
        Assert.Equal(expected, actual);
    }
}