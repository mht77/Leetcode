namespace LeetCode.Medium;

public class M1372
{
    public int LongestZigZag(TreeNode root)
    {
        var (left, right) = DFS(root, 0, 0);
        return Math.Max(left, right);
    }
    
    private (int, int) DFS(TreeNode? node, int left, int right)
    {
        if (node == null)
        {
            return (left, right);
        }
        
        var (leftLeft, leftRight) = DFS(node.left, 0, left + 1);
        var (rightLeft, rightRight) = DFS(node.right, right + 1, 0);
        
        return (Math.Max(leftLeft, rightLeft), Math.Max(leftRight, rightRight));
    }
}