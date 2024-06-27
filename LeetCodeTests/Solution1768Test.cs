namespace LeetCodeTests;
 
public class Solution1768Test : LeetCode.Problems.Solution1768
{
    [Theory]
    [InlineData("abc", "pqr", "apbqcr")]
    [InlineData("ab", "pqrs", "apbqrs")]
    [InlineData("abcd", "pq", "apbqcd")]
    public void MergeAlternately_Test(string firstWord, string secondWord, string expected)
    {
        var actual = MergeAlternately(firstWord, secondWord);
        Assert.Equal(expected, actual);
    }
}