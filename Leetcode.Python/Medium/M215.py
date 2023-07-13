import queue
from typing import List


class Solution:
    def findKthLargest(self, nums: List[int], k: int) -> int:
        q = queue.PriorityQueue()

        for num in nums:
            q.put((num, num))
        
        res = None

        k = len(nums)-k+1

        while k>0:
            res = q.get()
            k -= 1
        
        return res[1]