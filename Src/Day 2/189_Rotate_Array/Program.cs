namespace RotateArray;

public class Solution
{
    public void Rotate(int[] nums, int k)
    {
        if (nums.Length < 2)
            return;
        while (nums.Length < k)
        {
            k -= nums.Length;
        }
        int[] tmp = new int[k];
        int[] tmp2 = new int[nums.Length - k];
        int i = 0;
        for (; i < nums.Length - k; i++)
        {
            tmp2[i] = nums[i];
        }
        for (int j = 0; i < nums.Length; i++, j++)
        {
            tmp[j] = nums[i];
        }

        for (int j = 0; j < tmp.Length; j++)
        {
            nums[j] = tmp[j];
        }
        for (int j = 0; j < tmp2.Length; j++)
        {
            nums[j + k] = tmp2[j];
        }
    }
}
internal class Program
{
    static void Main(string[] args)
    {
    }
}