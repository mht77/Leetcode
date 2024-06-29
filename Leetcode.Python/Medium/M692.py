from typing import List


class Solution:
    def topKFrequent(self, words: List[str], k: int) -> List[str]:
        counts = {w: 0 for w in words}

        for word in words:
            counts[word] += 1

        counts = sorted(counts.items(), reverse=True, key=lambda item: item[1])
        buckets = [[counts[0]]]

        i = 0
        for j in range(1, len(counts)):
            if buckets[i][0][1] == counts[j][1]:
                buckets[i].append(counts[j])
            else:
                buckets.append([counts[j]])
                i += 1

        res = []

        for bucket in buckets:
            res.extend(sorted([item[0] for item in bucket]))
            if len(res) > k:
                res = res[:k]
                break

        return res
