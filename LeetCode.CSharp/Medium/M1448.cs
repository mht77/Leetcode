namespace LeetCode.Medium;

public class M1448
{
    public int GoodNodes(TreeNode root)
    {
        return DFS(root, 0, Int32.MinValue);
    }

    private int DFS(TreeNode? root, int n, int max)
    {
        if (root == null)
            return n;

        n = DFS(root.left, n, Math.Max(root.val, max));
        
        if (root.val >= max)
            n++;

        n = DFS(root.right, n, Math.Max(root.val, max));

        return n;
    }
}