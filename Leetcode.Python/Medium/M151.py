class Solution:
    def reverseWords(self, s: str) -> str:
        s = s.strip()
        res = ''
        word = ''

        for c in s:
            if c == ' ':
                if word != '':
                    res = word + ' ' + res
                word = ''
            else:
                word += c

        res = word + ' ' + res
        res = res.strip()
        return res
