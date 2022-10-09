namespace PopulatingNext;

// Definition for a Node.
public class Node
{
    public int val;
    public Node left;
    public Node right;
    public Node next;

    public Node() { }

    public Node(int _val)
    {
        val = _val;
    }

    public Node(int _val, Node _left, Node _right, Node _next)
    {
        val = _val;
        left = _left;
        right = _right;
        next = _next;
    }
}


public class Solution
{
    public Node ArrayToNode(int[] array)
    {
        // TODO
        return new Node();
    }

    public char[] NodeToArray(Node node)
    {
        return new char[] { };
    }

    private void connectRecursive(Node root)
    {
        Node level_start = root;
        while (level_start != null)
        {
            Node cur = level_start;
            while (cur != null)
            {
                if (cur.left != null) cur.left.next = cur.right;
                if (cur.right != null && cur.next != null) cur.right.next = cur.next.left;

                cur = cur.next;
            }
            level_start = level_start.left;
        }
    }

    public Node Connect(Node root)
    {
        connectRecursive(root);
        return root;
    }
}

internal class Program
{
    static void Main(string[] args)
    {
    }
}
