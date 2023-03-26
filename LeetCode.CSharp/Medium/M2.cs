namespace LeetCode.Medium;

public class M2
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        int sum = l1.val + l2.val;
        ListNode res = new ListNode(sum % 10);
        if (l1.next == null)
            res.next = Rec(null,  l2.next, sum > 9 ? 1 : 0);
        else if (l2.next == null)
            res.next = Rec(l1.next, null, sum > 9 ? 1 : 0);
        else
            res.next = Rec(l1.next, l2.next, l1.val + l2.val > 9 ? 1 : 0);
        return res;
    }

    private ListNode? Rec(ListNode? one, ListNode? two, int fromLast)
    {
        if (one == null && two == null && fromLast==0)
            return null;
        int sum = (one?.val ?? 0) + (two?.val ?? 0) + fromLast;
        ListNode res = new ListNode(sum % 10);
        res.next = Rec(one?.next ?? null, two?.next ?? null, sum > 9 ? 1 : 0);
        return res;
    }
}
