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

    private void makeFlat(ref Dictionary<int, int?> pairs, TreeNode? node, int idx = 1)
    {
        if (node == null)
            return;
        pairs.Add(idx, node.val);
        if (node.left != null)
            makeFlat(ref pairs, node.left, idx * 2);
        if (node.right != null)
            makeFlat(ref pairs, node.right, idx * 2 + 1);
    }

    public int?[] ToArray()
    {
        if (this is null)
            return new int?[] { null };

        Dictionary<int, int?>? pairs = new();
        makeFlat(ref pairs, this);

        var len = pairs.Keys.Max();
        var result = new int?[len];

        foreach ( var key in pairs.Keys )
        {
            result[key - 1] = pairs[key];
        }

        return result;
    }
}


public class Solution
{
    private TreeNode mergeNode(TreeNode? node1, TreeNode? node2, ref TreeNode? merged)
    {
        if (node1 is null && node2 is null)
            return null;
        if (merged is null)
            merged = new();
        merged.val = (node1?.val ?? 0) + (node2?.val ?? 0);
        merged.left = mergeNode(node1?.left ?? null, node2?.left ?? null, ref merged.left);
        merged.right = mergeNode(node1?.right ?? null, node2?.right ?? null, ref merged.right);
        return merged;
    }

    public TreeNode MergeTrees(TreeNode root1, TreeNode root2)
    {
        TreeNode merged = new();
        mergeNode(root1, root2, ref merged);
        return merged;
    }
}

internal class Program
{
    static void Main(string[] args)
    {
    }
}
