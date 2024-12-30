from typing import List


class Solution:
    def isValidSudoku(self, board: List[List[str]]) -> bool:
        count_cols = {i:{} for i in range(len(board))}
        count_rows = {i:{} for i in range(len(board))}
        count_squares = {(i, j):{} for i in range(3) for j in range(3)}

        for i in range(len(board)):
            for j in range(len(board[i])):
                ch = board[i][j]

                if ch == '.':
                    continue

                count_r = count_rows[i].get(ch, 0) + 1
                count_rows[i][ch] = count_r

                if count_r > 1:
                    return False

                count_c = count_cols[j].get(ch, 0) + 1
                count_cols[j][ch] = count_c

                if count_c > 1:
                    return False

                sq_i, sq_j = i//3, j//3
                count_sq = count_squares[(sq_i, sq_j)].get(ch, 0) + 1
                count_squares[(sq_i, sq_j)][ch] = count_sq

                if count_sq > 1:
                    return False

        return True