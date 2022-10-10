namespace Matrix;

public class Solution
{

    private int MinFromTopLeft(ref int[][] mat, int x, int y)
    {
        var top  = (y > 0) ? mat[y - 1][x] : int.MaxValue - 1;
        var left = (x > 0) ? mat[y][x - 1] : int.MaxValue - 1;
        return Math.Min(top, left) + 1;
    }

    private int MinFromBottomRight(ref int[][] mat, int x, int y)
    {
        var bottom = (y + 1 < mat.Length)    ? mat[y + 1][x] : int.MaxValue - 1;
        var right  = (x + 1 < mat[0].Length) ? mat[y][x + 1] : int.MaxValue - 1;
        return Math.Min(bottom, right) + 1;

    }

    public int[][] UpdateMatrix(int[][] mat)
    {
        int yMax = mat.Length;
        int xMax = mat[0].Length;
        int[][] result = new int[yMax][];
        for (int y = 0; y < yMax; y++)
        {
            result[y] = new int[xMax];
        }

        for (int y = 0; y < yMax; y++)
        {
            for (int x = 0; x < xMax; x++)
            {
                if (mat[y][x] == 0)
                {
                    result[y][x] = 0;
                    continue;
                }
                result[y][x] = MinFromTopLeft(ref mat, x, y);
            }
        }

        for (int y = yMax - 1; y >= 0; y--)
        {
            for (int x = xMax - 1; x >= 0; x--)
            {
                if (mat[y][x] == 0)
                {
                    result[y][x] = 0;
                    continue;
                }
                result[y][x] = Math.Min(result[y][x], MinFromBottomRight(ref mat, x, y));
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
