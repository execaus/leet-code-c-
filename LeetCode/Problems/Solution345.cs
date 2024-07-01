using System.Text;

namespace LeetCode.Problems;

public class Solution345
{
    private readonly HashSet<char> _vowels = new() { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
    private readonly StringBuilder _stringBuilder = new();
    public string ReverseVowels(string s) {
        if (s.Length < 2)
        {
            return s;
        }
        
        _stringBuilder.Clear();

        if (s.Length == 2)
        {
            return _vowels.Contains(s[0]) && _vowels.Contains(s[1]) ? String.Concat(s[1], s[0]) : s;
        }
        
        int leftIndex = 0, rightIndex = s.Length - 1;
        _stringBuilder.Append(s);

        bool isLeftStep = true;
        while (leftIndex != rightIndex && leftIndex < rightIndex)
        {
            if (isLeftStep)
            {
                if (_vowels.Contains(s[leftIndex]))
                {
                    isLeftStep = false;
                }
                else
                {
                    leftIndex++;
                }
            }
            else
            {
                if (_vowels.Contains(s[rightIndex]))
                {
                    (_stringBuilder[leftIndex], _stringBuilder[rightIndex]) = 
                        (_stringBuilder[rightIndex], _stringBuilder[leftIndex]);
                    leftIndex++;
                    isLeftStep = true;
                }
                
                rightIndex--;
            }
        }

        return _stringBuilder.ToString();
    }
}