namespace LeetCode.Easy;

public class E83
{
    public ListNode DeleteDuplicates(ListNode? head)
    {
        if (head == null)
            return null;
        var res = new ListNode(head.val);
        var lastVal = res.val;
        while (head != null)
        {
            if (lastVal != head.val)
            {
                AddToLast(res, head.val);
                lastVal = head.val;
            }
            
            head = head.next;
        }
        
        return res;
    }

    public ListNode AddToLast(ListNode? head, int val)
    {
        if (head.next == null)
        {
            head.next = new ListNode(val);
            return head;
        }
        return AddToLast(head.next, val);
    }
    
}

public class ListNode 
{
     public int val;
     public ListNode? next;
     public ListNode(int val=0, ListNode next=null)
     {
             this.val = val;
             this.next = next;
     }
}
