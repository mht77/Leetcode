class Solution:
    def mySqrt(self, x: int) -> int:
        if x == 0 or x == 1:
            return x
        s, e = 0, x
        while True:
            i = int((s + e)/2)
            if i * i <= x < (i + 1) * (i + 1):
                return i
            if i*i > x:
                e = i
            else:
                s = i
