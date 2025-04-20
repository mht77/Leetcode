from typing import List


class Solution:
    def combinationSum(self, candidates: List[int], target: int) -> List[List[int]]:
        combies = {21**i: (candidates[i], [candidates[i]]) for i in range(len(candidates))}
        indices = {c: i for i, c in enumerate(candidates)}
        visited = set()
        res = []
        for combie in combies.values():
            if combie[0] == target:
                res.append(combie[1])

        while True:
            l_before = len(combies)
            for key in list(combies.keys()):
                if key in visited: continue
                visited.add(key)
                for candidate in candidates:
                    value = combies[key]
                    new_sum = value[0] + candidate
                    if new_sum <= target:
                        new_key = key + 21**indices[candidate]
                        if new_key not in combies:
                            items = value[1] + [candidate]
                            combies[new_key] = (new_sum, items)
                            if value[0] + candidate == target:
                                res.append(items)

            if len(combies) == l_before:
                break

        return res
