from typing import Optional


class TreeNode:
    def __init__(self, val=0, left=None, right=None):
        self.val = val
        self.left = left
        self.right = right

class Solution:
    def leafSimilar(self, root1: Optional[TreeNode], root2: Optional[TreeNode]) -> bool:
        leaves1 = self.DFS(root1, [])
        leaves2 = self.DFS(root2, [])

        if len(leaves1) != len(leaves2):
            return False

        i = 0
        while i < len(leaves1):
            if leaves1[i] != leaves2[i]:
                return False
            i += 1

        return True


    def DFS(self, root: TreeNode, leaves: list):
        if not root:
            return leaves

        if not root.right and not root.left:
            leaves.append(root.val)
        else:
            self.DFS(root.left, leaves)
            self.DFS(root.right, leaves)

        return leaves