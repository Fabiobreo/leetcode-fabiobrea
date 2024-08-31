public class Solution
{
    public bool IsPalindrome(int x)
    {
        int reverse = 0;
        int c = x;
        while (c > 0)
        {
            reverse = reverse * 10 + c % 10;
            c /= 10;
        }
        return reverse == x;
    }
}