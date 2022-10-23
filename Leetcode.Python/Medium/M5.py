class Solution:
    def longestPalindrome(self, s: str) -> str:
        ln = len(s)
        t = [[False for _ in range(ln)] for _ in range(ln)]
        for i in range(ln):
            t[i][i] = True
        res = s[0]
        for i in range(ln-1, -1, -1):
            for j in range(i+1, ln):
                if s[i] == s[j]:
                    if j - i == 1 or t[i + 1][j - 1]:
                        t[i][j] = True
                        if len(s[i:j+1]) > len(res):
                            res = s[i:j+1]
        print(res)
        return res

    # def longestPalindrome(self, s: str) -> str:
    #     # brute force
    #     res = ''
    #     for i in range(len(s)):
    #         for j in range(len(s)):
    #             sub = s[i:len(s)-j]
    #             if self.check(sub):
    #                 if len(sub) > len(res):
    #                     res = sub
    #                 break
    #     return res

    # def check(self, string: str):
    #     for i in range(len(string)):
    #         if string[i] != string[len(string) - 1 - i]:
    #             return False
    #     return True
