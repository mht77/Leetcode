from typing import List


class Solution:
    def plusOne(self, digits: List[int]) -> List[int]:
        number = 0
        i = len(digits) - 1
        while i > -1:
            number += digits[i] * 10 ** (len(digits) - i - 1)
            i -= 1
        number += 1
        res = []
        while number > 0:
            res.insert(0, number % 10)
            number = int(number//10)
        return res

