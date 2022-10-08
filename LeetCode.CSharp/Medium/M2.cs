namespace LeetCode.Medium;

public class M2
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        int sum = l1.Val + l2.Val;
        ListNode res = new ListNode(sum % 10);
        if (l1.Next == null)
            res.Next = Rec(null,  l2.Next, sum > 9 ? 1 : 0);
        else if (l2.Next == null)
            res.Next = Rec(l1.Next, null, sum > 9 ? 1 : 0);
        else
            res.Next = Rec(l1.Next, l2.Next, l1.Val + l2.Val > 9 ? 1 : 0);
        return res;
    }

    private ListNode? Rec(ListNode? one, ListNode? two, int fromLast)
    {
        if (one == null && two == null && fromLast==0)
            return null;
        int sum = (one?.Val ?? 0) + (two?.Val ?? 0) + fromLast;
        ListNode res = new ListNode(sum % 10);
        res.Next = Rec(one?.Next ?? null, two?.Next ?? null, sum > 9 ? 1 : 0);
        return res;
    }
}



 public class ListNode {
     public int Val;
     public ListNode? Next;
     public ListNode(int val=0, ListNode? next=null) {
         Val = val;
         Next = next;
     }
 }
