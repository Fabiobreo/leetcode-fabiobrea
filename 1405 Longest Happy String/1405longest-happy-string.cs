public class Solution
{
    public string LongestDiverseString(int a, int b, int c)
    {
        int currA = 0;
        int currB = 0;
        int currC = 0;
        int maxIteration = a + b + c;
        StringBuilder result = new StringBuilder(maxIteration);
        for (int i = 0; i < maxIteration; ++i)
        {
            if ((a >= b && a >= c && currA != 2) ||
                (a > 0 && (currB == 2 || currC == 2)))
            {
                result.Append('a');
                a--;
                currA++;
                currB = 0;
                currC = 0;
            }
            else if ((b >= a && b >= c && currB != 2) ||
                (b > 0 && (currA == 2 || currC == 2)))
            {
                result.Append('b');
                b--;
                currB++;
                currA = 0;
                currC = 0;
            }
            else if ((c >= a && c >= b && currC != 2) ||
                (c > 0 && (currA == 2 || currB == 2)))
            {
                result.Append('c');
                c--;
                currC++;
                currA = 0;
                currB = 0;
            }
        }
        return result.ToString();
    }
}