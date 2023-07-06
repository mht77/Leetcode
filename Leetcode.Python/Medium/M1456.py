class Solution:
    def maxVowels(self, s: str, k: int) -> int:
        vowels = 'aeiou'
        c0 = 0

        for j in range(k):
            if s[j] in vowels:
                c0 += 1

        m = c0

        for i in range(k, len(s)):
            if s[i] in vowels:
                c0 += 1
            if s[i-k] in vowels:
                c0 -= 1

            m = max(m, c0)

        return m
