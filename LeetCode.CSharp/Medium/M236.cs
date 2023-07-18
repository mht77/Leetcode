namespace LeetCode.Medium;

public class M236
{
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
        var pVisits = DFSSearch(root, p, new Queue<TreeNode>()).Item1;
        var qVisits = DFSSearch(root, q, new Queue<TreeNode>()).Item1;

        while (pVisits.Count > qVisits.Count)
            pVisits.Dequeue();

        while (qVisits.Count > pVisits.Count)
            qVisits.Dequeue();

        var pTop = pVisits.Dequeue();
        var qTop = qVisits.Dequeue();

        while (pTop.val != qTop.val)
        {
            pTop = pVisits.Dequeue();
            qTop = qVisits.Dequeue();
        }

        return pTop;
    }

    private (Queue<TreeNode>, bool) DFSSearch(TreeNode? root, TreeNode toFind, Queue<TreeNode> visited)
    {
        if (root == null)
            return (visited, false);

        if (root.val == toFind.val)
        {
            visited.Enqueue(root);
            return (visited, true);
        }

        var left = DFSSearch(root.left, toFind, visited);

        if (left.Item2)
        {
            visited = left.Item1;
            visited.Enqueue(root);
            return (visited, true);
        }

        var right = DFSSearch(root.right, toFind, visited);
        
        if (right.Item2)
        {
            visited = right.Item1;
            visited.Enqueue(root);
            return (visited, true);
        }

        return (visited, false);
    }
}