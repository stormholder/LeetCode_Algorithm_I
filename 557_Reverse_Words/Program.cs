using System.Text;

namespace ReverseWords;

public class Solution
{
    private string reverseWord(string word)
    {
        char[] s = word.ToCharArray();
        int j = s.Length - 1;
        int s1 = s.Length % 2 != 0 ? (s.Length / 2) : (s.Length / 2) - 1;
        for (int i = 0; i <= s1; i++)
        {
            char c = s[i];
            s[i] = s[j];
            s[j] = c;
            j--;
        }
        return new string(s);
    }
    public string ReverseWords(string s)
    {
        StringBuilder sb = new();

        var words = s.Split(' ');
        
        for (int i = 0; i < words.Length; i++)
        {
            var rWord = reverseWord(words[i]);
            sb.Append(rWord);
            if (i < words.Length - 1)
            {
                sb.Append(" ");
            }
        }

        return sb.ToString();
    }
}

internal class Program
{
    static void Main(string[] args)
    {
    }
}