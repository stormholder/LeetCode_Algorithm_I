namespace TwoSum2;

public class Solution
{
    public int[] TwoSum(int[] numbers, int target)
    {
        int[] nums = new int[2];
        int l = 0;
        int r = numbers.Length - 1;
        while (l < r)
        {
            if (numbers[l] + numbers[r] < target)
            {
                l++;
            }
            if (numbers[l] + numbers[r] > target)
            {
                r--;
            }
            if (numbers[l] + numbers[r] == target)
            {
                nums[0] = l + 1;
                nums[1] = r + 1;
                return nums;
            }
        }
        return nums;
    }
}

internal class Program
{
    static void Main(string[] args)
    {
    }
}