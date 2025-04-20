class Solution:
    def countAndSay(self, n: int) -> str:
        res = "1"
        for _ in range(n-1):
            res = self.convert(res)

        return res


    def convert(self, prev: str):
        res = []
        i = 0
        count = 1
        while i < len(prev) - 1:
            if prev[i] == prev[i+1]:
                count += 1
            else:
                res.append(f'{count}{prev[i]}')
                count = 1

            i += 1

        res.append(f'{count}{prev[i]}')

        return ''.join(res)
