namespace FirstBadVersion;

public class Solution : VersionControl
{
    public int FirstBadVersion(int n)
    {
        decimal L = 0;
        decimal R = n;
        int result = n;
        while (R - L > 1)
        {
            var m = (int)Math.Ceiling((L + R) / 2);
            if (IsBadVersion(m))
            {
                result = m;
                R = m;
            } else
            {
                L = m;
            }
        }
        return result;
    }
}

//isBadVersion API emulation
public class VersionControl
{
    public int Bad { get; set; } = 0;
    public bool IsBadVersion(int version)
    {
        return version == Bad;
    }
}

internal class Program
{
    static void Main(string[] args)
    {
    }
}