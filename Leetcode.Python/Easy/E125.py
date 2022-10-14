class Solution:
    def isPalindrome(self, s: str) -> bool:
        s = ''.join([i for i in s if i.isalnum()])
        s = s.replace(" ", '')
        s = s.lower()
        for i in range(len(s)):
            if s[i] != s[len(s)-1-i]:
                return False
        return True
