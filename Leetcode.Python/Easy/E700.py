from typing import Optional


class TreeNode:
    def __init__(self, val=0, left=None, right=None):
        self.val = val
        self.left = left
        self.right = right

class Solution:
    def searchBST(self, root: Optional[TreeNode], val: int) -> Optional[TreeNode]:
        return self.DFS(root, val)


    def DFS(self, root: TreeNode, val):
        if not root:
            return

        if val == root.val:
            return root

        if val < root.val:
            r = self.DFS(root.left, val)
            if r:
                return r

        if val > root.val:
            r = self.DFS(root.right, val)
            if r:
                return r

        return None