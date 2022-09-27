class Solution:
    def addBinary(self, a: str, b: str) -> str:
        res = ''
        ai = 0
        bi = 0
        c = len(a)-1
        while c > -1:
            ai += int(a[c]) * 2**(len(a)-1-c)
            c -= 1
        c = len(b)-1
        while c > -1:
            bi += int(b[c]) * 2**(len(b)-1-c)
            c -= 1
        s = ai + bi
        if s == 0:
            return str(s)
        c = 0
        while s > 0:
            res = str(s % 2) + res
            s = int(s // 2)
            c += 1
        return res
