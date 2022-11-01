namespace LeetCode.Easy;

public class E94
{
    public IList<int> InorderTraversal(TreeNode root)
    {
        IList<int> res = new List<int>();
        res = InOrder(root, res);
        return res;
    }

    public IList<int> InOrder(TreeNode? node, IList<int> list)
    {
        if (node != null)
        {
            InOrder(node.left, list);
            list.Add(node.val);
            InOrder(node.right, list);
        }

        return list;
    }
}

public class TreeNode 
{
     public int val;
     public TreeNode? left;
     public TreeNode? right;
     
     public TreeNode(int val=0, TreeNode? left=null, TreeNode? right=null)
     {
         this.val = val;
         this.left = left;
         this.right = right;
     }
}