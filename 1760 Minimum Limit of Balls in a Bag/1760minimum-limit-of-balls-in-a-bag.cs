public class Solution
{
    public int MinimumSize(int[] nums, int maxOps)
    {
        int possibleMax = nums.Max(), impossibleMax = 0, candidate = (possibleMax+impossibleMax)/2;
        while(candidate > impossibleMax)
        {
            var opsRequired = nums.Sum(x => GetRequiredOpsToGetToTarget(x, candidate));
            if(opsRequired > maxOps)
                impossibleMax = candidate;
            else
                possibleMax = candidate;
            candidate = (possibleMax+impossibleMax)/2;
        }
        return possibleMax;
    }

    private int GetRequiredOpsToGetToTarget(int num, int target)
    {
        return (num <= target) ? 0 : (int) Math.Ceiling(num/(double)target)-1;
    }
}