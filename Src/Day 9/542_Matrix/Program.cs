namespace Matrix;

public class Solution
{

    private int MinStepsTopLeft(ref int[][] mat, int x, int y)
    {
        int[] neighbours = new int[2] { 100000, 100000 };

        if (y - 1 >= 0)
        {
            neighbours[0] = mat[y - 1][x];
        }
        if (x - 1 >= 0)
        {
            neighbours[1] = mat[y][x - 1];
        }
        return Math.Min(neighbours[0], neighbours[1]) + 1;
    }

    private int MinStepsBottomRight(ref int[][] mat, int x, int y, int currentStepsCount)
    {
        int yMax = mat.Length;
        int xMax = mat[0].Length;
        int[] neighbours = new int[2] { 100000, 100000 };
        if (y + 1 < yMax)
        {
            neighbours[0] = mat[y + 1][x];
        }
        if (x + 1 < xMax)
        {
            neighbours[1] = mat[y][x + 1];
        }
        var minBottomRight = Math.Min(neighbours[0], neighbours[1]) + 1;

        return Math.Min(currentStepsCount, minBottomRight);

    }

    public int[][] UpdateMatrix(int[][] mat)
    {
        int[][] result = new int[mat.Length][];
        for (int i = 0; i < mat.Length; i++)
        {
            result[i] = new int[mat[i].Length];
        }

        for (int y = 0; y < mat.Length; y++)
        {
            for (int x = 0; x < mat[y].Length; x++)
            {
                if (mat[y][x] == 0)
                {
                    result[y][x] = 0;
                    continue;
                }
                result[y][x] = MinStepsTopLeft(ref mat, x, y);
            }
        }

        for (int y = mat.Length - 1; y >= 0; y--)
        {
            for (int x = mat[y].Length - 1; x >= 0; x--)
            {
                if (mat[y][x] == 0)
                {
                    result[y][x] = 0;
                    continue;
                }
                result[y][x] = MinStepsBottomRight(ref mat, x, y, result[y][x]);
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
