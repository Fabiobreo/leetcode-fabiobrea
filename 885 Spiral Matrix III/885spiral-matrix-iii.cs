public class Solution {
    public int[][] SpiralMatrixIII(int rows, int cols, int rStart, int cStart) {
        int[][] directions = new int[][] {
            new int[] {0, 1}, // right
            new int[] {1, 0}, // down
            new int[] {0, -1}, // left
            new int[] {-1, 0} // up
        };
        
        int totalCells = rows * cols;
        int[][] result = new int[totalCells][];
        int currentRow = rStart, currentCol = cStart;
        int dirIndex = 0, steps = 1;
        int count = 0;
        
        result[count++] = new int[] {currentRow, currentCol};
        
        while (count < totalCells) {
            for (int i = 0; i < 2; ++i) { // Two times for each steps (spiral step increment)
                for (int j = 0; j < steps; ++j) {
                    currentRow += directions[dirIndex][0];
                    currentCol += directions[dirIndex][1];
                    if (currentRow >= 0 && currentRow < rows && currentCol >= 0 && currentCol < cols) {
                        result[count++] = new int[] {currentRow, currentCol};
                    }
                }
                dirIndex = (dirIndex + 1) % 4; // Change direction
            }
            steps++; // Increment the steps after a full turn
        }
        
        return result;
    }
}