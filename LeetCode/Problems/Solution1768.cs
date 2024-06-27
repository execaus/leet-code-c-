using System.Text;

namespace LeetCode.Problems;

/**
 * You are given two strings word1 and word2. Merge the strings by adding letters in alternating order,
 * starting with word1. If a string is longer than the other, append the additional letters onto
 * the end of the merged string. Return the merged string.
 */
public class Solution1768
{
    private readonly StringBuilder _stringBuilder = new();
    
    public string MergeAlternately(string word1, string word2)
    {
        _stringBuilder.Clear();

        for (int i = 0; i < Math.Max(word1.Length, word2.Length); i++)
        {
            if (word1.Length > i)
            {
                _stringBuilder.Append(word1[i]);
            }
            if (word2.Length > i)
            {
                _stringBuilder.Append(word2[i]);
            }
        }

        return _stringBuilder.ToString();
    }
}