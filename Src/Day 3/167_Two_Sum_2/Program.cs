namespace TwoSum2;

public class Solution
{
    public int[] TwoSum(int[] numbers, int target)
    {
        int p = 0;
        int i = 1;
        while(i < numbers.Length)
        {
            int a = numbers[p];
            int delta = target - a;
            int deltaIndex = -1;
            for (int j = i; j < numbers.Length; j++)
            {
                if (numbers[j] == delta)
                {
                    deltaIndex = j;
                    break;
                }
            }
            if (deltaIndex < 0)
            {
                p++;
            }
            else
            {
                i = deltaIndex;
                break;
            }
            i++;
        }

        return new int[2] { p + 1, i + 1 };
    }
}

internal class Program
{
    static void Main(string[] args)
    {
    }
}