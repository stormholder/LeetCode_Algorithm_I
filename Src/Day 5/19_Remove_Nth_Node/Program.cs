namespace RemoveNthNode;

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class Solution
{
    private int Count(int counter, ListNode head)
    {
        if (head == null)
            return counter;
        return Count(counter + 1, head.next);
    }

    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        int length = Count(0, head);
        int toRemove = length - n;
        //Console.WriteLine($"Remove {toRemove}th element");
        int[] prefixVals = new int[toRemove];
        int[] suffixVals = new int[n - 1];
        if (prefixVals.Length == 0 && suffixVals.Length == 0)
        {
            return null;
        }
        ListNode node = head;
        if (prefixVals.Length > 0)
        {
            for (int i = 0; i < toRemove; i++)
            {
                prefixVals[i] = node.val;
                node = node.next;
            }
        }
        node = node.next;
        if (suffixVals.Length > 0)
        {
            int j = 0;
            while (node != null || j < n - 2)
            {
                suffixVals[j] = node.val;
                j++;
                node = node.next;
            }
        }

        //Console.WriteLine($"Prefixes: {string.Join(',', prefixVals)}");
        //Console.WriteLine($"Suffixes: {string.Join(',', suffixVals)}");

        node = null;
        ListNode prevNode = null;
        if (suffixVals.Length > 0)
        {
            for (int k = suffixVals.Length - 1; k >= 0; k--)
            {
                node = new(suffixVals[k], prevNode);
                prevNode = node;
            }
        }
        if (prefixVals.Length > 0)
        {
            for (int k = prefixVals.Length - 1; k >= 0; k--)
            {
                node = new(prefixVals[k], prevNode);
                prevNode = node;
            }
        }
        return node;
    }

    public List<int> ToList(ref List<int> list, ListNode head)
    {
        if (head == null)
            return list;
        list.Add(head.val);
        return ToList(ref list, head.next);
    }
}

internal class Program
{
    static void Main(string[] args)
    {
    }
}