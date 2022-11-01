from typing import Optional


class TreeNode:
    def __init__(self, val=0, left=None, right=None):
        self.val = val
        self.left = left
        self.right = right


class Solution:
    def isSameTree(self, p: Optional[TreeNode], q: Optional[TreeNode]) -> bool:
        return (p and q and p.val == q.val and self.isSameTree(p.left, q.left) and self.isSameTree(p.right, q.right)) \
               or (not p and not q)
