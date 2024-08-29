public class Solution
{
    public int MinSwaps(int[] nums) 
    {
        int n = nums.Length;
        
        int totalOnes = 0;
        foreach (int num in nums)
        {
            if (num == 1)
            {
                totalOnes++;
            }
        }
        
        if (totalOnes <= 1)
        {
            return 0;
        }
        
        int[] prefixSum = new int[n + 1];
        for (int i = 0; i < n; i++)
        {
            prefixSum[i + 1] = prefixSum[i] + nums[i];
        }
        
        int minSwaps = int.MaxValue;
        for (int i = 0; i < n; i++)
        {
            int end = i + totalOnes - 1;
            int currentOnes;
            
            if (end < n)
            {
                currentOnes = prefixSum[end + 1] - prefixSum[i];
            } else
            {
                currentOnes = (prefixSum[n] - prefixSum[i]) + (prefixSum[end - n + 1]);
            }
            
            minSwaps = Math.Min(minSwaps, totalOnes - currentOnes);
        }
        
        return minSwaps;
    }
}