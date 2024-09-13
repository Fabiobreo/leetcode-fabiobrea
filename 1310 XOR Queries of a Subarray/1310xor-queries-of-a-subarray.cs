public class Solution
{
    public int[] XorQueries(int[] arr, int[][] queries) 
    {
        int[] result = new int[queries.Length];
        for (int j = 0; j < queries.Length; ++j)
        {
            var xor = 0;
            for (int i = queries[j][0]; i <= queries[j][1]; ++i)
            {
                xor = xor ^ arr[i];
            }
            result[j] = xor;
        }
        return result;
    }
}