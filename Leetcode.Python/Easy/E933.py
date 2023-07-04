class RecentCounter:

    def __init__(self):
        self.requests = []

    def ping(self, t: int) -> int:
        self.requests.append(t)

        nxt = self.requests[0]

        while nxt < t - 3000:
            self.requests.pop(0)
            nxt = self.requests[0]

        return len(self.requests)