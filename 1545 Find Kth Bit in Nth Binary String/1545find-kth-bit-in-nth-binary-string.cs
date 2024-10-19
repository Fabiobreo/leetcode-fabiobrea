public class Solution
{
    public char FindKthBit(int n, int k)
    {
        int numInversion = 0;
        int len = (1 << n) - 1; // Length of Sn
        while (k > 1)
        {
            if (k == len / 2 + 1)
            {
                return numInversion % 2 == 0 ? '1': '0';
            }

            if (k > len / 2)
            {
                k = len + 1 - k;
                numInversion++;
            }
            len /= 2;
        }
        return numInversion % 2 == 0 ? '0' : '1';
    }
}