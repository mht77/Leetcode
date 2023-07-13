from typing import Optional


class TreeNode:
    def __init__(self, val=0, left=None, right=None):
        self.val = val
        self.left = left
        self.right = right

class Solution:
    def deleteNode(self, root: Optional[TreeNode], key: int) -> Optional[TreeNode]:
        return self.DFS(root, key)


    def DFS(self, root: TreeNode, k: int):
        if not root:
            return root

        if root.val > k:
            root.left = self.DFS(root.left, k)    

        if root.val == k:
            if not root.right:
                return root.left
            elif not root.left:
                return root.right
            else:
                minimum = root.right
                while minimum.left:
                    minimum = minimum.left
                root.val = minimum.val
                root.right = self.DFS(root.right, minimum.val)
                return root
        
        if root.val < k:
            root.right = self.DFS(root.right, k)

        return root