namespace BinarySearch;

public class Solution
{
    decimal Left { get; set; } = 0;
    decimal Right { get;set; } = 0;
    private decimal m = 0;
    public int Search(int[] nums, int target)
    {
        Left = 0;
        Right = nums.Length - 1;
        while (Left != Right)
        {
            m = Math.Ceiling((Left + Right) / 2);
            if (nums[(int)m] > target)
            {
                Right = m - 1;
            } else
            {
                Left = m;
            }
        }
        return (int)((nums[(int)Left] == target) ? Left : -1);
    }
}

internal class Program
{
    static void Main(string[] args)
    {
    }
}