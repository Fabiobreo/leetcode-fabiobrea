public class Solution
{
    public bool PrimeSubOperation(int[] nums)
    {
        int maxElement = GetMaxElement(nums);

        bool[] sieve = new bool[maxElement + 1];
        Fill(sieve, true);
        sieve[1] = false;

        for (int p = 2; p <= Math.Sqrt(maxElement + 1); ++p)
        {
            if (sieve[p])
            {
                for (int j = p * p; j <= maxElement; j += p)
                {
                    sieve[j] = false;
                }
            }
        }

        int currValue = 1;
        int i = 0;
        while (i < nums.Length)
        {
            int difference = nums[i] - currValue;

            if (difference < 0)
            {
                return false;
            }

            if (sieve[difference] == true || difference == 0)
            {
                i++;
                currValue++;
            }
            else
            {
                currValue++;
            }
        }
        return true;
    }

    private int GetMaxElement(int[] nums)
    {
        int max = -1;
        foreach (int num in nums)
        {
            max = Math.Max(max, num);
        }
        return max;
    }

    private void Fill(bool[] arr, bool value)
    {
        for (int i = 0; i < arr.Length; ++i)
        {
            arr[i] = value;
        }
    }
}