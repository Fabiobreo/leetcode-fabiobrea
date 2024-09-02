public class Solution
{
    public int HIndex(int[] citations)
    {
        int n = citations.Length;
        Array.Sort(citations);
        for (int i = 0; i < n; i++)
        {
            if (citations[i] >= n - i)
            {
                return n - i;
            } 
        }
        return 0;
        
    }
}