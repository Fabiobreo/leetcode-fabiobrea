public class Solution
{
    public int[] FinalPrices(int[] prices)
    {
        var stack = new Stack<int>();
        var result = new int[prices.Length];
        for (int i = 0; i < prices.Length; i++)
        {
            result[i] = prices[i];
            while (stack.Count > 0 && prices[stack.Peek()] >= prices[i])
            {
                result[stack.Pop()] -= prices[i]; 
            }
            stack.Push(i);
        }
        return result;
    }
}