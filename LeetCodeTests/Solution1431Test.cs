using LeetCode.Problems;

namespace LeetCodeTests;

public class Solution1431Test : Solution1431
{
    [Theory]
    [InlineData(new int[] {2,3,5,1,3}, 3, new bool[] {true,true,true,false,true})]
    [InlineData(new int[] {4,2,1,1,2}, 1, new bool[] {true,false,false,false,false})]
    [InlineData(new int[] {12,1,12}, 10, new bool[] {true,false,true})]
    public void GcdOfStrings_Test(int[] candies, int extraCandies, IList<bool> expected)
    {
        var actual = KidsWithCandies(candies, extraCandies);
        Assert.Equal(expected, actual);
    }
}