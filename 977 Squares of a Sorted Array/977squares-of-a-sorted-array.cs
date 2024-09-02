public class Solution
{
    public int[] SortedSquares(int[] nums)
    {
        var squared = new int[nums.Length];
        if (nums[0] >= 0)
        {
            for (int i = 0; i < nums.Length; ++i)
            {
                squared[i] = nums[i] * nums[i];
            }
            return squared;
        }
        else
        {
            int positiveIndex = -1;
            for (int i = 0; i < nums.Length; ++i)
            {
                if (nums[i] >= 0)
                {
                    positiveIndex = i;
                    break;
                }
            }

            if (positiveIndex == -1)
            {
                int reverseIndex = nums.Length - 1;
                for (int i = 0; i < nums.Length; ++i)
                {
                    squared[reverseIndex] = nums[i] * nums[i];
                    reverseIndex--;
                }
                return squared;
            }

            int negativeIndex = positiveIndex - 1;
            int currentPositionIndex = 0;
            while (negativeIndex >= 0 && positiveIndex < nums.Length)
            {
                if (Math.Abs(nums[negativeIndex]) < Math.Abs(nums[positiveIndex]))
                {
                    squared[currentPositionIndex] = nums[negativeIndex] * nums[negativeIndex];
                    negativeIndex--;
                }
                else
                {
                    squared[currentPositionIndex] = nums[positiveIndex] * nums[positiveIndex];
                    positiveIndex++;
                }
                currentPositionIndex++;
            }

            while (negativeIndex >= 0)
            {
                squared[currentPositionIndex] = nums[negativeIndex] * nums[negativeIndex];
                negativeIndex--;
                currentPositionIndex++;
            }

            while (positiveIndex < nums.Length)
            {
                squared[currentPositionIndex] = nums[positiveIndex] * nums[positiveIndex];
                positiveIndex++;
                currentPositionIndex++;
            }
        }
        return squared;
    }
}