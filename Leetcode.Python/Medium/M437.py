from typing import Optional


class TreeNode:
    def __init__(self, val=0, left=None, right=None):
        self.val = val
        self.left = left
        self.right = right


class Solution:
    def pathSum(self, root: Optional[TreeNode], targetSum: int) -> int:
        sums = self.DFS(root, 0, [], [])
        count = 0

        for i in sums:
            if targetSum == i:
                count += 1

        print(count)
        return count


    def DFS(self, root: TreeNode, s: int, sums: list, visitedNodes: list):

        if not root:
            return []

        visitedNodes.append(root.val)

        for i in range(len(visitedNodes)):
            sums.append(sum(visitedNodes[i:]))

        vN = list(visitedNodes)

        self.DFS(root.left, s, sums, vN)

        self.DFS(root.right, s, sums, visitedNodes)

        return sums
