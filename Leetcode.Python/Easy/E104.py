from typing import Optional


class TreeNode:
    def __init__(self, val=0, left=None, right=None):
        self.val = val
        self.left = left
        self.right = right

class Solution:
    def maxDepth(self, root: Optional[TreeNode]) -> int:
        return self.dfs(root, 0)


    def dfs(self, root, depth):
        if not root:
            return depth

        depth += 1

        depth_left = self.dfs(root.left, depth)

        depth_right = self.dfs(root.right, depth)

        return max(depth_right, depth_left)
