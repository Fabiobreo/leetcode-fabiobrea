public class Solution
{
    public long MaximumSubarraySum(int[] nums, int k)
    {
        int n = nums.Length;
        HashSet<int> elements = new HashSet<int>();
        long currentSum = 0;
        long maxSum = 0;
        int begin = 0;
        
        for (int end = 0; end < n; end++) 
        {
            if (!elements.Contains(nums[end]))
            {
                currentSum += nums[end];
                elements.Add(nums[end]);
                
                if (end - begin + 1 == k)
                {
                    maxSum = Math.Max(maxSum, currentSum);
                    
                    currentSum -= nums[begin];
                    elements.Remove(nums[begin]);
                    begin++;
                }
            }
            else
            {
                while (nums[begin] != nums[end])
                {
                    currentSum -= nums[begin];
                    elements.Remove(nums[begin]);
                    begin++;
                }
                begin++;
            }
        }
        
        return maxSum;
    }
}