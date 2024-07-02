using System.Text;

namespace LeetCode.Problems;

public class Solution151
{
    private const char SpaceChar = ' ';
    
    private readonly StringBuilder _stringBuilder = new();
    
    public string ReverseWords(string s) {
        if (s.Length < 2)
        {
            return s;
        }

        _stringBuilder.Clear();
        _stringBuilder.Capacity = s.Length;

        int insertIndex = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == SpaceChar)
            {
                insertIndex = 0;
            }
            else
            {
                if (insertIndex == 0 && _stringBuilder.Length != 0)
                {
                    _stringBuilder.Insert(0, SpaceChar);
                }
                
                _stringBuilder.Insert(insertIndex, s[i]);
                insertIndex++;
            }
        }

        return _stringBuilder.ToString();
    }
}