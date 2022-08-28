from typing import List


def diagonalSort(mat: List[List[int]]) -> List[List[int]]:
    for row in range(len(mat)):
        diag = []
        for index in range(row, len(mat)):
            if index - row == len(mat[0]):
                break
            diag.append(mat[index][index - row])
        diag = sorted(diag)
        for index in range(row, len(mat)):
            if index - row == len(mat[0]):
                break
            mat[index][index - row] = diag[index - row]
    for col in range(1, len(mat[0])):
        diag = []
        for index in range(col, len(mat[0])):
            if index-col == len(mat):
                break
            diag.append(mat[index-col][index])
        diag = sorted(diag)
        for index in range(col, len(mat[0])):
            if index-col == len(mat):
                break
            mat[index-col][index] = diag[index - col]
    return mat
