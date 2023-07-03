from typing import Optional, List


class TreeNode:
    def __init__(self, val=0, left=None, right=None):
        self.val = val
        self.left = left
        self.right = right

class Solution:
    def rightSideView(self, root: Optional[TreeNode]) -> List[int]:
        return self.BFS(root)

    def BFS(self, root):
        if not root:
            return []

        nodes = [(root, 0)] # queue
        res = [(root, 0)]

        while len(nodes) > 0:
            node, lvl = nodes.pop(0)

            last = res.pop()
            if last[1] != lvl:
                res.append(last)

            res.append((node, lvl))

            if node.left:
                nodes.append((node.left, lvl+1))

            if node.right:
                nodes.append((node.right, lvl+1))

        return [n.val for n, _ in res]