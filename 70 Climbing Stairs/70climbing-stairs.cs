public class Solution {

    private int[] memo = new int[45];

    public int ClimbStairs(int n) {
        if (n == 1)
        {
            memo[0] = 1;
            return 1;
        }
        else if (n == 2)
        {
            memo[1] = 2;
            return 2;
        }

        if (memo[n - 2] == 0)
        {
            memo[n - 2] = ClimbStairs(n - 1);
        }
        if (memo[n - 3] == 0)
        {
            memo[n - 3] = ClimbStairs(n - 2);
        }

        return memo[n - 2] + memo[n - 3];
    }
}