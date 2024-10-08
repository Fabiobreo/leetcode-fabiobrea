public class Solution
{
    public int MinSwaps(string s)
    {
        int stackSize = 0;
        for (int i = 0; i < s.Length; ++i)
        {
            var ch = s[i];
            if (ch == '[')
            {
                stackSize++;
            }
            else
            {
                if (stackSize > 0)
                {
                    stackSize--;
                }
            }
        }
        return (stackSize + 1) / 2;
    }
}