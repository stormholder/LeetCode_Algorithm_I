namespace _206_Reverse_Linked;

public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
}

public class Solution {
    public ListNode ReverseList(ListNode head) {
        if (head == null || head.next == null)
            return head;
        
        ListNode iterator = ReverseList(head.next);
        head.next.next = head;
        head.next = null;
        return iterator;
    }
}

internal class Program
{
    static void Main(string[] args)
    {
    }
}