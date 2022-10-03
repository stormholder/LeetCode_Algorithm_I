namespace FloodFill;

public struct Tile
{
    public int X;
    public int Y;
    public int Color;
}

public class Solution
{
    private bool ShouldBeColored(ref int[][] map, Tile tile, int color) => map[tile.X][tile.Y] != color;

    public int[][] FloodFill(int[][] image, int sr, int sc, int color)
    {
        int[][] result = new int[image.Length][];
        bool[,] visited = new bool[image[0].Length, image.Length];
        for (int y = 0; y < image.Length; y++)
        {
            result[y] = new int[image[0].Length];
            for (int x = 0; x < image[0].Length; x++)
            {
                result[y][x] = image[y][x];
                visited[x, y] = false;
            }
        }

        Queue<Tile> queue = new();
        Tile start = new Tile() { X = sr, Y = sc, Color = image[sr][sc] };
        queue.Enqueue(start);

        while (queue.Count > 0)
        {
            var tile = queue.Dequeue();
            result[tile.X][tile.Y] = color;
            visited[tile.Y, tile.X] = true;
            if (tile.X > 0)
            {
                var left = new Tile() { X = tile.X - 1, Y = tile.Y, Color = image[tile.X - 1][tile.Y] };
                if (!visited[left.Y,left.X] && left.Color == image[sr][sc] && ShouldBeColored(ref result, left, color))
                {
                    queue.Enqueue(left);
                }
            }
            if (tile.X < image.Length - 1)
            {
                var right = new Tile() { X = tile.X + 1, Y = tile.Y, Color = image[tile.X + 1][tile.Y] };
                if (!visited[right.Y, right.X] && right.Color == image[sr][sc] && ShouldBeColored(ref result, right, color))
                {
                    queue.Enqueue(right);
                }
            }
            if (tile.Y > 0)
            {
                var up = new Tile() { X = tile.X, Y = tile.Y - 1, Color = image[tile.X][tile.Y - 1] };
                if (!visited[up.Y, up.X] && up.Color == image[sr][sc] && ShouldBeColored(ref result, up, color))
                {
                    queue.Enqueue(up);
                }
            }
            if (tile.Y < image[0].Length - 1)
            {
                var down = new Tile() { X = tile.X, Y = tile.Y + 1, Color = image[tile.X][tile.Y + 1] };
                if (!visited[down.Y, down.X] && down.Color == image[sr][sc] && ShouldBeColored(ref result, down, color))
                {
                    queue.Enqueue(down);
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