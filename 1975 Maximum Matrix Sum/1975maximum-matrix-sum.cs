public class Solution
{
    public long MaxMatrixSum(int[][] matrix)
    {
        int smallest = 100001;
        int numNegatives = 0;
        long maxSum = 0;
        int n = matrix.Length;
        for (int i = 0; i < n; ++i)
        {
            for (int j = 0; j < n; ++j)
            {
                int value = Math.Abs(matrix[i][j]);
                maxSum += value;
                if (value < smallest)
                {
                    smallest = value;
                }

                if (matrix[i][j] < 0)
                {
                    numNegatives++;
                }
            }
        }

        if (numNegatives % 2 == 1)
        {
            maxSum -= 2* smallest;
        }

        return maxSum;
    }
}