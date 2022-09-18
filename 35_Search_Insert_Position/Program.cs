namespace SearchInsertPosition;

public class Solution
{
    public int SearchInsert(int[] nums, int target)
    {
        decimal L = 0;
        decimal R = nums.Length - 1;
        int result = nums.Length - 1;

        if (nums[result] < target)
        {
            return result + 1;
        }
        while (R - L > 1)
        {
            var m = (int)Math.Ceiling((L + R) / 2);
            if (nums[m] == target)
            {
                result = m;
                break;
            }
            if (nums[m] > target)
            {
                R = m - 1;
                result = m - 1;
            }
            else
            {
                L = m;
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