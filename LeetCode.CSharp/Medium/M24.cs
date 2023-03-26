namespace LeetCode.Medium;



public class M24
{
    public ListNode SwapPairs(ListNode head)
    {
        // if (head == null)  // only for the null list in leetcode! 
        //     return head;
        
        if (head.next == null)
            return head;
        
        var res = head.next;

        var temp = new ListNode(head.val)
        {
            next = res.next
        };

        res.next = temp;
        
        if (res.next.next != null)
            res.next.next = SwapPairs(res.next.next);

        return res;
    }
}