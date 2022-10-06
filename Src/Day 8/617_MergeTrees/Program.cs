namespace MergeTrees;

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }

    public override bool Equals(object? obj)
    {
        return obj is TreeNode node &&
               val == node.val &&
               EqualityComparer<TreeNode>.Default.Equals(left, node.left) &&
               EqualityComparer<TreeNode>.Default.Equals(right, node.right);
    }

    public TreeNode FromArray(ref int?[] root, int idx = 0)
    {
        if (idx >= root.Length || root[idx] == null)
            return null;
        TreeNode node = new();
        node.val = (int)root[idx]!;
        node.left = FromArray(ref root, (idx + 1) * 2 - 1);
        node.right = FromArray(ref root, (idx + 1) * 2);
        return node;
    }

    public int?[] ToArray(ref TreeNode? root, ref List<int?> values, int idx = 0)
    {
        // TODO
        if (root is null)
            return new int?[] { null };

        return new int?[] { null };
    }
}


public class Solution
{
    public TreeNode MergeTrees(TreeNode root1, TreeNode root2)
    {
        return new TreeNode();
    }
}

internal class Program
{
    static void Main(string[] args)
    {
    }
}
