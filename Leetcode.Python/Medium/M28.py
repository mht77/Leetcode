def strStr(haystack: str, needle: str) -> int:
    if len(needle) == 0:
        return 0
    if len(haystack) < len(needle):
        return -1
    i = 0
    while i < len(haystack):
        if haystack[i:i+len(needle)] == needle:
            return i
        i += 1
    return -1
