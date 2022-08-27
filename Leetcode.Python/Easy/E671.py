from typing import Optional


class TreeNode:
    def __init__(self, val=0, left=None, right=None):
        self.val = val
        self.left = left
        self.right = right


class Solution:
    res = []

    def findSecondMinimumValue(self, root: Optional[TreeNode]) -> int:
        if not root.left:
            return -1
        Solution.res.clear()
        self.addList(root)
        sr = sorted(Solution.res)
        second = sr[0]
        i = 1
        while second == sr[0]:
            if i == len(sr):
                return -1
            second = sr[i]
            i += 1
        return second

    def addList(self, node: TreeNode):
        if node:
            if node.left:
                self.addList(node.left)
                Solution.res.append(node.val)
                self.addList(node.right)
            else:
                Solution.res.append(node.val)
