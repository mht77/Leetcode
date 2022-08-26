def isValid(s: str) -> bool:
    brackets = {'[': ']', '{': '}', '(': ')'}
    reverse_brackets = {']': '[', '}': '{', ')': '('}
    stack = []
    if len(s) % 2 == 1:
        return False
    for char in s:
        if char in brackets.values() and reverse_brackets[char] not in stack:
            return False
        elif char in brackets.keys():
            stack.insert(0, char)
        elif char in brackets.values():
            last = stack.pop(0)
            if brackets[last] != char:
                return False
    if len(stack) != 0:
        return False
    return True
