namespace LeetCodeTests;

public class Solution345Test : LeetCode.Problems.Solution345
{
    [Theory]
    [InlineData("hello", "holle")]
    [InlineData("leetcode", "leotcede")]
    [InlineData("race car", "race car")]
     public void ReverseVowels_Test(string s, string expected)
    {
        var actual = ReverseVowels(s);
        Assert.Equal(expected, actual);
    }
}