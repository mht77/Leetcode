from typing import List


class Solution:
    def combinationSum2(self, candidates: List[int], target: int) -> List[List[int]]:
        candidates.sort()
        res = {}

        def backtrack(s, t, path):
            if t == 0:
                res[tuple(path)] = path
                return
            for i in range(s, len(candidates)):
                if i > s and candidates[i] == candidates[i - 1]:
                    continue
                if candidates[i] > t:
                    break
                backtrack(i + 1, t - candidates[i], path + [candidates[i]])

        backtrack(0, target, [])
        return list(res.values())
