from typing import List


class Solution:
    def canVisitAllRooms(self, rooms: List[List[int]]) -> bool:
        visited = set()

        keys = set()
        keys.add(0)

        while len(keys) > 0:
            room = keys.pop()

            while room in visited and len(keys) > 0:
                room = keys.pop()

            if room in visited:
                break

            room_keys = rooms[room]

            for room_key in room_keys:
                keys.add(room_key)

            visited.add(room)

        return len(visited) == len(rooms)
