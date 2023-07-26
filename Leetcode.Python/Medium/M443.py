from typing import List


class Solution:
    def compress(self, chars: List[str]) -> int:
        j = 0
        i = 0
        last = chars[0]

        while j <= len(chars):
            if j < len(chars) and chars[j] == last:
                i += 1
                last = str(chars[j])
                chars.pop(j)
            else:
                chars.insert(j, last)
                if i != 1:
                    c = str(i)
                    j += 1
                    for n in c:
                        chars.insert(j, n)
                        j += 1
                else:
                    j += 1
                i = 0
                if j < len(chars):
                    last = chars[j]
                else:
                    break

        return len(chars)