public class Solution {
    public int TrailingZeroes(int n)
    {
        int trailingZeros = 0;
        while (n >= 5)
        {
            n /= 5;
            trailingZeros += n;
        }
        return trailingZeros;
    }
}