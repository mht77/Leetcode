# The guess API is already defined for you.
# @param num, your guess
# @return -1 if num is higher than the picked number
#          1 if num is lower than the picked number
#          otherwise return 0
def guess(num: int) -> int:
    pass

class Solution:
    def guessNumber(self, n: int) -> int:
        start = 1
        end = n

        if guess(start) == 0:
            return start

        if guess(end) == 0:
            return end

        while start < end:
            num = (start+end)//2
            res = guess(num)


            if res == 0:
                return num

            if res == 1:
                start = num

            if res == -1:
                end = num