from typing import List


class Solution:
    def productExceptSelf(self, nums: List[int]) -> List[int]:
        answer = []
        pre = [1]
        pos = [1]

        p_pre = 1
        p_post = 1

        for num in nums:
            p_pre *= num
            pre.append(p_pre)

        for i in range(len(nums)-1, -1, -1):
            p_post *= nums[i]
            pos.insert(0, p_post)

        for i in range(len(nums)):
            answer.append(pre[i] * pos[i+1])

        return answer
