namespace TwoSum2;

public class Solution
{
    public int[] TwoSum(int[] numbers, int target)
    {
        int[] nums = new int[2];
        int l = 0;
        int r = numbers.Length - 1;
        //untill left is less than right pointer //this is same template of two pointer
        while (l < r)
        {
            //1st condition if adding numbers are less than target we increase left pointer

            if (numbers[l] + numbers[r] < target)
            {
                l++;
            }
            //2nd condition if adding numbers are greater than target we decrease right pointer
            if (numbers[l] + numbers[r] > target)
            {
                r--;
            }
            //if we found the target and two element then assign both index with adding 1(as it is asking 1-index)
            if (numbers[l] + numbers[r] == target)
            {
                nums[0] = l + 1;
                nums[1] = r + 1;
                //return at last after assining
                return nums;
            }
        }
        //then return as empty
        return nums;
        //int p = 0;
        //int i = 1;
        //while(i < numbers.Length)
        //{
        //    int a = numbers[p];
        //    int delta = target - a;
        //    int deltaIndex = -1;
        //    for (int j = i; j < numbers.Length; j++)
        //    {
        //        if (numbers[j] == delta)
        //        {
        //            deltaIndex = j;
        //            break;
        //        }
        //    }
        //    if (deltaIndex < 0)
        //    {
        //        p++;
        //    }
        //    else
        //    {
        //        i = deltaIndex;
        //        break;
        //    }
        //    i++;
        //}

        //return new int[2] { p + 1, i + 1 };
    }
}

internal class Program
{
    static void Main(string[] args)
    {
    }
}