namespace LeetCode.Problems;

public class Solution1431
{
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        var max = candies.Max();
        return candies.ToList().ConvertAll(value => value + extraCandies >= max);
    }
}