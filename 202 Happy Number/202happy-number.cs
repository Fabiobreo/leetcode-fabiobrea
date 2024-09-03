public class Solution {
    public bool IsHappy(int n) {
        HashSet<int> seen = new HashSet<int>();
        while (n != 1)
        {
            int source = n;
            int newNum = 0;
            while (source > 0)
            {
                var digit = source % 10;
                source /= 10;
                newNum += (int)Math.Pow(digit, 2);
            }

            if (seen.Contains(newNum))
            {
                return false;
            }
            seen.Add(newNum);
            n = newNum;
        }
        return true;
    }

    public static IEnumerable<int> GetDigits(int source)
    {
        while (source > 0)
        {
            var digit = source % 10;
            source /= 10;
            yield return digit;
        }
    }
}