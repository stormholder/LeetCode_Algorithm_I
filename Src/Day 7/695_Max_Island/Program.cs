namespace MaxIsland;

public struct Tile
{
    public int X;
    public int Y;
}
public class Solution
{
    public int MaxAreaOfIsland(int[][] grid)
    {
        bool[,] visited = new bool[grid[0].Length, grid.Length];
        List<int> islandSizes = new();
        List<Tile> tiles = new List<Tile>();

        for (int y = 0; y < grid.Length; y++)
        {
            for (int x = 0; x < grid[y].Length; x++)
            {
                visited[x, y] = grid[y][x] == 0;
                if (grid[y][x] == 1)
                {
                    tiles.Add(new Tile() { X = x, Y = y });
                }
            }
        }

        if (!tiles.Any())
            return 0;

        foreach (var t in tiles)
        {
            if (visited[t.X, t.Y])
                continue;
            Queue<Tile> queue = new();
            int islandSize = 0;
            queue.Enqueue(new Tile() { X = t.X, Y = t.Y });
            while (queue.Count > 0)
            {
                var tile = queue.Dequeue();
                visited[tile.X, tile.Y] = true;
                islandSize++;
                if (tile.X > 0)
                {
                    var left = new Tile() { X = tile.X - 1, Y = tile.Y };
                    if (!visited[left.X, left.Y] && grid[tile.Y][tile.X - 1] == 1)
                    {
                        visited[left.X, left.Y] = true;
                        queue.Enqueue(left);
                    }
                }
                if (tile.X < grid[0].Length - 1)
                {
                    var right = new Tile() { X = tile.X + 1, Y = tile.Y };
                    if (!visited[right.X, right.Y] && grid[tile.Y][tile.X + 1] == 1)
                    {
                        visited[right.X, right.Y] = true;
                        queue.Enqueue(right);
                    }
                }
                if (tile.Y > 0)
                {
                    var up = new Tile() { X = tile.X, Y = tile.Y - 1 };
                    if (!visited[up.X, up.Y] && grid[tile.Y - 1][tile.X] == 1)
                    {
                        visited[up.X, up.Y] = true;
                        queue.Enqueue(up);
                    }
                }
                if (tile.Y < grid.Length - 1)
                {
                    var down = new Tile() { X = tile.X, Y = tile.Y + 1 };
                    if (!visited[down.X, down.Y] && grid[tile.Y + 1][tile.X] == 1)
                    {
                        visited[down.X, down.Y] = true;
                        queue.Enqueue(down);
                    }
                }
            }
            islandSizes.Add(islandSize);
        }


        return islandSizes.Max();
    }
}

internal class Program
{
    static void Main(string[] args)
    {
    }
}