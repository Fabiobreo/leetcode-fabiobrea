public class Solution
{
    public int ChalkReplacer(int[] chalk, int k)
    {
        long totalChalkNeeded = 0;
        foreach (int studentChalkUse in chalk)
        {
            totalChalkNeeded += studentChalkUse;
        }
        
        int remainingChalk = (int)(k % totalChalkNeeded);
        
        for (int i = 0; i < chalk.Length; ++i)
        {
            if (remainingChalk < chalk[i])
            {
                return i;
            }
            remainingChalk -= chalk[i];
        }
        
        return 0;
    }
}