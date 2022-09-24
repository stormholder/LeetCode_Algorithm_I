namespace ReverseString;

public class Solution
{
    public void ReverseString(char[] s)
    {
        bool isOdd = s.Length % 2 == 0;
        int il = isOdd ? s.Length / 2 - 1 : s.Length / 2;
        int ir = isOdd ? il + 1 : il;
        char tmp;
        while (il >= 0)
        {
            if (s[il] != s[ir])
            {
                tmp = s[il];
                s[il] = s[ir];
                s[ir] = tmp;
            }
            il--;
            ir++;
        }
    }
}

internal class Program
{
    static void Main(string[] args)
    {
    }
}