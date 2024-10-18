public class Solution
{
    public int CountMaxOrSubsets(int[] nums)
    {
        int n = nums.Length;
        int maxOrValue = 0;
        foreach (var num in nums)
        {
            maxOrValue |= num;
        }

        int[,] memo = new int[n, maxOrValue + 1];
        for (int i = 0; i < n; ++i)
        {
            for (int j = 0; j <= maxOrValue; ++j)
            {
                memo[i, j] = -1;
            }
        }
        return CountSubsets(nums, 0, 0, maxOrValue, memo);
    }

    private int CountSubsets(int[] nums, int index, int currentOr, int targetOr, int[,] memo)
    {
        if (index == nums.Length)
        {
            return (currentOr == targetOr) ? 1 : 0;
        }

        if (memo[index, currentOr] != -1)
        {
            return memo[index, currentOr];
        }

        int countWithoutNum = CountSubsets(nums, index + 1, currentOr, targetOr, memo);
        int countWithNum = CountSubsets(nums, index + 1, currentOr | nums[index], targetOr, memo);

        memo[index, currentOr] = countWithNum + countWithoutNum;
        return memo[index, currentOr];
    }
}