public class Solution
{
    public int[] Decrypt(int[] code, int k)
    {
        if (k == 0)
        {
            for (int j = 0; j < code.Length; j++)
                code[j] = 0;
            return code;
        }

        int curSum = 0;
        int start = 1;
        if (k < 0)
        {
            k = k * -1;
            start = code.Length - k;
        }

        int end = (start - 1) % code.Length;
        int i = 0;
        while (i < k)
        {
            end = (end + 1) % code.Length;
            curSum += code[(end) % code.Length];
            i++;
        }

        int[] ans = new int[code.Length];
        for (i = 0; i < code.Length; i++)
        {
            ans[i] = curSum;
            curSum -= code[start];
            start = (start + 1) % code.Length;
            end = (end + 1) % code.Length;
            curSum += code[end];
        }
        return ans;
    }
}