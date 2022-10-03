namespace LongestSubstring;

public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        if (s.Length < 2) return s.Length;
        int left = 0;
        int right = 1;
        HashSet<char> letters = new();
        int result = 0;
        char[] chars = s.ToCharArray();

        while (left < right && right < chars.Length)
        {
            letters.Clear();
            for(int i = left; i < right; i++)
            {
                if (letters.Contains(chars[i]))
                {
                    left++;
                    right = (right < chars.Length) ? left + 1 : right;
                    break;
                }
                var delta = right - left;
                result = delta > result ? delta : result;
                letters.Add(chars[i]);
                if (right < chars.Length)
                    right++;
            }
        }

        return result;
    }
}

internal class Program
{
    static void Main(string[] args)
    {
    }
}