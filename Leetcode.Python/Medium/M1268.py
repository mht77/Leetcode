from typing import List


class Solution:

    class Trie:

        def __init__(self):
            self.children = {}
            self.words = []
            self.eow = False

        def insert(self, word: str) -> None:
            if word == "" or not word:
                return

            node = self
            for i in range(len(word)):
                l = word[i]
                if not l in node.children:
                    node.children[l] = Solution.Trie()
                if i == len(word) - 1:
                    node.children[l].eow = True

                node.words.append(word)
                node = node.children[l]

        def search(self, word: str) -> list:
            node = self

            for l in word:
                if not l in node.children:
                    return []

                node = node.children[l]

            if node.eow:
                node.words.insert(0, word)

            return sorted(node.words)[:3]

    def suggestedProducts(self, products: List[str], searchWord: str) -> List[List[str]]:
        trie = self.Trie()

        for product in products:
            trie.insert(product)

        res = []

        for i in range(len(searchWord)):
            word = searchWord[:i+1]
            res.append(trie.search(word))

        return res