class Solution:
    def reverseVowels(self, s: str) -> str:
        vowels = 'aeiouAEIOU'
        start = 0
        end = len(s)-1
        s = list(s)

        while start < end:
            if s[start] not in vowels:
                start += 1

            if s[end] not in vowels:
                end -= 1

            if s[end] in vowels and s[start] in vowels:
                s[start], s[end] = s[end], s[start]
                start += 1
                end -= 1

        return "".join(s)