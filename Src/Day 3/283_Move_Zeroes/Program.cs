namespace MoveZeroes;

public class Solution
{
    public void MoveZeroes(int[] nums)
    {
        int i1 = 0;
        int i2 = 0;
        while( i2 < nums.Length )
        {
            if (nums[i2] != 0)
            {
                var tmp = nums[i1];
                nums[i1] = nums[i2];
                nums[i2] = tmp;
                i1++;
            }
            i2++;
        }
    }
}

internal class Program
{
    static void Main(string[] args)
    {
    }
}