public class Solution
{
    public int GetSum(int a, int b)
    {
        while (b != 0)
        {
            var carry = b & a;
            a ^= b;
            b = carry << 1;
        }
        return a;
    }
}