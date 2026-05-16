public class Solution {
    public int[][] GenerateMatrix(int n) {
        int[][] matrix = new int[n][];
        for(int i = 0; i < n; i++){
            matrix[i] = new int[n];
        }

        int[] dr = { 0, 1, 0, -1 }; // Direction array for rows
        int[] dc = { 1, 0, -1, 0 }; // Direction array for columns
        int dir = 0; // Start with the right direction

        int row = 0, col = 0;
        for (int value = 1; value <= n * n; value++)
        {
            matrix[row][col] = value;
            int nextRow = row + dr[dir];
            int nextCol = col + dc[dir];

            if (nextRow < 0 || nextRow >= n || nextCol < 0 || nextCol >= n || matrix[nextRow][nextCol] != 0)
            {
                dir = (dir + 1) % 4; // Change direction
                nextRow = row + dr[dir];
                nextCol = col + dc[dir];
            }

            row = nextRow;
            col = nextCol;
        }
        return matrix;
    }
}