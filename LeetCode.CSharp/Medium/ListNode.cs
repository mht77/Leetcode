namespace LeetCode.Medium;

public class ListNode
{
    public int val;
    public ListNode? next;
    public ListNode(int val=0, ListNode? next=null) {
        this.val = val;
        this.next = next;
    }

    public void ConsoleWrite()
    {
        Console.Write(val);
        while (next != null)
        {
            Console.Write($", {next.val}");
            next = next.next;
        }
    }
}