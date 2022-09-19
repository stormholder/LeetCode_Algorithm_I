namespace Squares;
public class Solution
{
    public int[] SortedSquares(int[] nums)
    {
        int[] result = new int[nums.Length];
        for (int i = 0; i < result.Length; i++)
        {
            result[i] = nums[i] * nums[i];
        }
        Array.Sort(result);
        return result;
    }
}

internal class Program
{
    static void Main(string[] args)
    {
    }
}