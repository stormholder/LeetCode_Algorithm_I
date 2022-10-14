namespace Matrix;

public struct Tile
{
    public int X {get;set;}
    public int Y {get;set;}
}

public class Solution
{
    private readonly int[,] DIRECTIONS = new int[,]{{-1,0},{1,0},{0,-1},{0,1}};

    public int[][] UpdateMatrix(int[][] mat)
    {
        int yMax = mat.Length;
        int xMax = mat[0].Length;
        int[][] result = new int[yMax][];
        for (int y = 0; y < yMax; y++)
        {
            result[y] = new int[xMax];
            Array.Fill(result[y], int.MaxValue - 1);
        }
        Queue<Tile> queue = new();
        for (int y = 0; y < yMax; y++)
        {
            for (int x = 0; x < xMax; x++)
            {
                if (mat[y][x] == 0)
                {
                    result[y][x] = 0;
                    queue.Enqueue(new Tile() { X = x, Y = y });
                }
            }
        }

        while (queue.Count > 0)
        {
            Tile tile = queue.Dequeue();
            for (int i = 0; i < 4; i++)
            {
                int new_row = tile.Y + DIRECTIONS[i, 0];
                int new_col = tile.X + DIRECTIONS[i, 1];
                
                if(new_row >= 0 && new_col >= 0 && new_row < yMax && new_col < xMax)
                {
                    if(result[new_row][new_col] > result[tile.Y][tile.X] + 1)
                    {
                        result[new_row][new_col] = result[tile.Y][tile.X] + 1;
                        queue.Enqueue(new Tile() { Y = new_row, X = new_col });
                    }
                }
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
