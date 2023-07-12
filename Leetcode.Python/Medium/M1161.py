from typing import Optional


class TreeNode:
    def __init__(self, val=0, left=None, right=None):
        self.val = val
        self.left = left
        self.right = right

class Solution:
    def maxLevelSum(self, root: Optional[TreeNode]) -> int:
        s = self.DFS(root, {}, 1)
        m = None
        l = 1

        for k in s:
            if m is None or m < s[k]:
                m = s[k]
                l = k

        return l


    def DFS(self, root: TreeNode, s: dict, level: int):

        if not root:
            return s

        if not s.get(level):
            s[level] = root.val
        else:
            s[level] += root.val

        s = self.DFS(root.left, s, level+1)

        s = self.DFS(root.right, s, level+1)

        return s