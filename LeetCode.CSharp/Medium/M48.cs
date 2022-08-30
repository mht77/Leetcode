namespace LeetCode.Medium;

public class M48
{
    public void Rotate(int[][] matrix) {
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = i; j < matrix.Length - i; j++)
            {
                if (j==matrix.Length-1-i)
                    break;
                var temp = matrix[i][j];
                matrix[i][j] = matrix[matrix.Length-j-1][i];
                matrix[matrix.Length - j - 1][i] = matrix[matrix.Length - i - 1][matrix.Length - j - 1];
                matrix[matrix.Length - i - 1][matrix.Length - j - 1] = matrix[j][matrix.Length - i - 1];
                matrix[j][matrix.Length - i - 1] = temp;
            }
        }
    }
}