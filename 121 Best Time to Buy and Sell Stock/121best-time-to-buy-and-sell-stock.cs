public class Solution {
    public int MaxProfit(int[] prices) {
        int minValue = int.MaxValue;
        int currentMaxValue = 0;
        for (int i = 0; i < prices.Length; ++i)
        {
            if (prices[i] < minValue)
            {
                minValue = prices[i];
            }
            int value = prices[i] - minValue;
            if (value > currentMaxValue)
            {
                currentMaxValue = value;
            }
        }
        return currentMaxValue;
    }
}