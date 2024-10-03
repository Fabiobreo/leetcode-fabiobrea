public class Solution
{
    public int MinSubarray(int[] nums, int p)
    {
        int n = nums.Length;
        int totalSum = 0;
        foreach (int num in nums)
        {
            totalSum = (totalSum + num) % p;
        }

        int target = totalSum % p;
        if (target == 0) 
        {
            return 0;
        }

        var modMap = new Dictionary<int, int>();
        modMap.Add(0, - 1);
        int currentSum = 0;
        int minLen = n;

        for (int i = 0; i < n; i++)
        {
            currentSum = (currentSum + nums[i]) % p;
            int needed = (currentSum - target + p) % p;
            if (modMap.ContainsKey(needed))
            {
                minLen = Math.Min(minLen, i - modMap[needed]);
            }

            modMap[currentSum] = i;
        }
        return minLen == n ? -1 : minLen;
    }
}