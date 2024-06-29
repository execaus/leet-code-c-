using System.Text;

namespace LeetCode.Problems;

/**
 * For two strings s and t, we say "t divides s" if and only if s = t + t + t + ... + t + t
 * (i.e., t is concatenated with itself one or more times). Given two strings str1 and str2,
 * return the largest string x such that x divides both str1 and str2.
 */
public class Solution1071
{
    public string GcdOfStrings(string str1, string str2)
    {
        if (str1 + str2 != str2 + str1) {
            return "";
        }

        int gcdLength = gcd(str1.Length, str2.Length);
        return str1.Substring(0, gcdLength); 
    }
    
    private int gcd(int firstLength, int secondLength) {
        if (secondLength == 0) {
            return firstLength;
        } else {
            return gcd(secondLength, firstLength % secondLength);
        }    
    }
}