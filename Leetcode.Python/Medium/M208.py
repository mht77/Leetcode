class Trie:

    def __init__(self):
        self.children = {}
        self.eow = False

    def insert(self, word: str) -> None:
        if word == "" or not word:
            return
        
        node = self
        for i in range(len(word)):
            l = word[i]
            if not l in node.children:
                node.children[l] = Trie()
            if i == len(word)-1:
                node.children[l].eow = True  
            node = node.children[l]
        

    def search(self, word: str) -> bool:
        node = self

        for l in word:
            if not l in node.children:
                return False
            
            node = node.children[l]
        
        return node.eow

    def startsWith(self, prefix: str) -> bool:
        node = self

        for l in prefix:
            if not l in node.children:
                return False
            
            node = node.children[l]
        
        return True