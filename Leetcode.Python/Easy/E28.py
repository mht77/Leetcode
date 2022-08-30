def strStr(haystack: str, needle: str) -> int:
    if len(needle) == 0:
        return 0
    if len(haystack) < len(needle):
        return -1
    for c in range(len(haystack)):
        if haystack[c] == needle[0]:
            for i in range(len(needle)):
                if c+i == len(haystack):
                    break
                if haystack[c + i] != needle[i]:
                    break
                if i == len(needle) - 1:
                    return c
    return -1
