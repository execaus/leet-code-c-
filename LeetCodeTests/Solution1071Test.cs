namespace LeetCodeTests;

public class Solution1071Test : LeetCode.Problems.Solution1071
{
    [Theory]
    [InlineData("ABCABC", "ABC", "ABC")]
    [InlineData("ABABAB", "ABAB", "AB")]
    [InlineData("LEET", "CODE", "")]
    [InlineData("TAUXXTAUXXTAUXXTAUXXTAUXX", "TAUXXTAUXXTAUXXTAUXXTAUXXTAUXXTAUXXTAUXXTAUXX", "TAUXX")]
    [InlineData("ABABABAB", "ABAB", "ABAB")]
    public void GcdOfStrings_Test(string str1, string str2, string expected)
    {
        var actual = GcdOfStrings(str1, str2);
        Assert.Equal(expected, actual);
    }
}