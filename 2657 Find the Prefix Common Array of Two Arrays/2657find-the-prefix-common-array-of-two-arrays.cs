public class Solution
{
    public int[] FindThePrefixCommonArray(int[] A, int[] B)
    {
        int n = A.Length;
        var freq = new int[51];
        var result = new int[n];
        int current = 0;
        for (int i = 0; i < n; i++)
        {
            freq[A[i]]++;
            freq[B[i]]++;
            if (A[i] != B[i])
            {
                if (freq[A[i]] % 2 == 0)
                {
                    current++;
                }
                if (freq[B[i]] % 2 == 0)
                {
                    current++;
                }
            }
            else
            {
                current++;
            }
            result[i] = current;
        }
        return result;
    }
}