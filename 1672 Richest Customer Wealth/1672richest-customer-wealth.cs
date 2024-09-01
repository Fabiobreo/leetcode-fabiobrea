public class Solution {
    public int MaximumWealth(int[][] accounts) {
        int max = 0;
        for (int row = 0; row < accounts.Length; row++)
        {
            var customer = accounts[row];
            int wealth = 0;
            for (int column = 0; column < customer.Length; column++)
            {
                wealth += customer[column];
            }

            if (wealth > max)
            {
                max = wealth;
            }
        }
        return max;
    }
}