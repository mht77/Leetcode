from Easy.E20 import isValid
from Easy.E671 import Solution, TreeNode


def main():
    root = TreeNode(2)
    root.left = TreeNode(2)
    root.right = TreeNode(2)
    print(Solution().findSecondMinimumValue(root))
    print(isValid("()[]{}"))


if __name__ == '__main__':
    main()
