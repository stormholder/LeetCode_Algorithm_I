using System.Collections.Generic;

namespace RottingOranges;

public class Solution
{
    private readonly int[,] DIRECTIONS = new int[,]{{-1,0},{1,0},{0,-1},{0,1}};

    private bool CanRot(ref int[][] grid, int[] neighbour) => 
        neighbour[1] >= 0 && neighbour[0] >= 0 &&
        neighbour[1] < grid.Length && neighbour[0] < grid[0].Length &&
        grid[neighbour[1]][neighbour[0]] == 1;

    private IEnumerable<int[]> GetNeighboursToRot(ref int[][] grid, int[] current)
    {
        List<int[]> neighbours = new();

        for (int i = 0; i < 4; i++)
        {
            int new_col = current[0] + DIRECTIONS[i, 1];
            int new_row = current[1] + DIRECTIONS[i, 0];
            var n = new int[2]{ new_col, new_row };
            if (CanRot(ref grid, n))
            {
                neighbours.Add(n);
            }
        }

        return neighbours;
    }

    public int OrangesRotting(int[][] grid)
    {
        int yMax = grid.Length;
        int xMax = grid[0].Length;
        if (xMax == 0 || yMax == 0)
            return -1;
        int totalMinutes = 0;
        Queue<int[]> queue = new();
        int freshOranges = 0;
        for (int y = 0; y < yMax; y++)
        {
            for (int x = 0; x < xMax; x++)
            {
                if (grid[y][x] == 2)
                {
                    queue.Enqueue(new int[2] { x, y });
                }
                if (grid[y][x] == 1)
                {
                    freshOranges++;
                }
            }
        }

        if (freshOranges == 0)
            return 0;

        while(queue.Count > 0)
        {
            ++totalMinutes;
            int qSize = queue.Count;
            for (int i = 0; i < qSize; i++)
            {
                var orange = queue.Dequeue();
                var neighbours = GetNeighboursToRot(ref grid, orange);
                foreach (var neighbour in neighbours)
                {
                    grid[neighbour[1]][neighbour[0]] = 2;
                    freshOranges--;
                    queue.Enqueue(neighbour);
                }
            }
        }

        return freshOranges == 0 ? totalMinutes - 1 : -1;
    }
}

internal class Program
{
    static void Main(string[] args)
    {
    }
}
