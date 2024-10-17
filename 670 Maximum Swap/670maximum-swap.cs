public class Solution
{
    public int MaximumSwap(int num)
    {
        var numStr = num.ToString().ToCharArray();
        int n = numStr.Length;
        int[] maxRightIndex = new int[n];
        maxRightIndex[n - 1] = n - 1;
        for (int i = n - 2; i >= 0; i--)
        {
            maxRightIndex[i] = numStr[i] > numStr[maxRightIndex[i + 1]] ? i : maxRightIndex[i + 1];
        }

        for (int i = 0; i < n; ++i)
        {
            if (numStr[i] < numStr[maxRightIndex[i]])
            {
                char tmp = numStr[i];
                numStr[i] = numStr[maxRightIndex[i]];
                numStr[maxRightIndex[i]] = tmp;
                return int.Parse(new string(numStr));
            }
        }
        return num;
    }
}