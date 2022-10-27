class Solution:
    def myAtoi(self, s: str) -> int:
        if len(s) == 0:
            return 0
        digits = ['1', '2', '3', '4', '5',
                  '6', '7', '8', '9', '0']
        s = s.lstrip()
        if len(s) == 0:
            return 0
        is_neg = s[0] == '-'
        s = s[1:] if s[0] == '-' or s[0] == '+' else s
        res = ''
        while len(s) > 0:
            if s[0] in digits:
                res = res + s[0]
                s = s[1:]
            else:
                break
        if len(res) == 0:
            return 0
        r = int(res) if not is_neg else -int(res)
        if r > 2 ** 31 - 1:
            r = 2 ** 31 - 1
        if r < -2 ** 31:
            r = -2 ** 31
        return r
