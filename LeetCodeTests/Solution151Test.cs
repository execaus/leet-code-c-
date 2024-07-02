namespace LeetCodeTests;

public class Solution151Test : LeetCode.Problems.Solution151
{
    [Theory]
    [InlineData("the sky is blue", "blue is sky the")]
    [InlineData("  hello world  ", "world hello")]
    [InlineData("a good   example", "example good a")]
    public void ReverseWords_Test(string s, string expected)
    {
        var actual = ReverseWords(s);
        Assert.Equal(expected, actual);
    }
}