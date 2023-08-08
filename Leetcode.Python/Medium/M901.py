class StockSpanner:

    def __init__(self):
        self.stocks = []

    def next(self, price: int) -> int:
        if len(self.stocks) == 0:
            self.stocks.append((price, 1))
            return 1

        if price < self.stocks[-1][0]:
            self.stocks.append((price, 1))
            return 1

        count = 1
        while len(self.stocks) > 0 and price >= self.stocks[-1][0]:
            count += self.stocks.pop()[1]

        self.stocks.append((price, count))
        return count