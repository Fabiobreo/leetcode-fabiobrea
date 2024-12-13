public class Solution
{
    public int[] TwoSum(int[] numbers, int target)
    {
        int rightIndex = numbers.Length - 1;
        int leftIndex = 0;
        while (leftIndex < rightIndex)
        {
            var current = numbers[rightIndex] + numbers[leftIndex];
            if (current > target)
            {
                rightIndex--;
            }
            else if (current < target)
            {
                leftIndex++;
            }
            else
            {
                return new int[] { leftIndex + 1, rightIndex + 1 };
            }
        }
        return null;
    }
}