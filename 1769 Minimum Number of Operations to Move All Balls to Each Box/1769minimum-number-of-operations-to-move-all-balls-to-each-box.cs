public class Solution
{
    public int[] MinOperations(string boxes)
    {
        int n = boxes.Length;
        int[] answer = new int[n];
        int ballsToLeft = 0;
        int movesToLeft = 0;
        int ballsToRight = 0;
        int movesToRight = 0;

        for (int i = 0; i < n; ++i)
        {
            answer[i] += movesToLeft;
            ballsToLeft += boxes[i] - '0';
            movesToLeft += ballsToLeft;

            int j = n - 1 - i;
            answer[j] += movesToRight;
            ballsToRight += boxes[j] - '0';
            movesToRight += ballsToRight;
        }
        return answer;
    }
}