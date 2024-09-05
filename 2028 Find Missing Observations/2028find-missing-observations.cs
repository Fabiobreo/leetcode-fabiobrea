public class Solution
{
    public int[] MissingRolls(int[] rolls, int mean, int n)
    {
        int missing = mean * (rolls.Length + n) - rolls.Sum();
        if (missing < 0)
        {
            return new int[] {};
        }

        int[] result = new int[n];
        int baseValue = missing / n;
        int rest = missing % n;
        for (int i = 0; i < n; ++i)
        {
            if (baseValue > 6 || baseValue < 1)
            {
                return new int[] {};
            }

            result[i] = baseValue;
            if (i < rest)
            {
                if (baseValue > 5)
                {
                   return new int[] {};
                }
                result[i]++;
            }
        }
        return result;
    }
}