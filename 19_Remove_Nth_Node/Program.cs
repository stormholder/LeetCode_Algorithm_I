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
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        ListNode result = new();
        return result;
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