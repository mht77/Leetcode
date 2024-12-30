package leetcodego

func IsValidSudoku(board [][]byte) bool {
	countCols := make(map[int]map[byte]int, len(board))
	countRows := make(map[int]map[byte]int, len(board))
	countSquares := make(map[[2]int]map[byte]int, len(board))

	for i := 0; i < len(board); i++ {
		for j := 0; j < len(board[i]); j++ {
			ch := board[i][j]

			if ch == '.' {
				continue
			}

			if countCols[j] == nil {
				countCols[j] = make(map[byte]int)
			}

			if countRows[i] == nil {
				countRows[i] = make(map[byte]int)
			}

			countRows[i][ch]++

			if countRows[i][ch] > 1 {
				return false
			}

			countCols[j][ch]++

			if countCols[j][ch] > 1 {
				return false
			}

			squareRow := i / 3
			squareCol := j / 3

			if countSquares[[2]int{squareRow, squareCol}] == nil {
				countSquares[[2]int{squareRow, squareCol}] = make(map[byte]int)
			}

			countSquares[[2]int{squareRow, squareCol}][ch]++

			if countSquares[[2]int{squareRow, squareCol}][ch] > 1 {
				return false
			}
		}
	}

	return true
}
