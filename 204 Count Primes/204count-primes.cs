public class Solution {
    public int CountPrimes(int n)
    {
        if (n < 2)
        {
            return 0;
        }
        
        int count = 0;
        var prime = new bool[n];
        prime[0] = false;
        prime[1] = false;
        for (int i = 2; i < n; ++i)
        {
            prime[i] = true;
        }

        for (int i = 2; i < n; ++i)
        {
            if (prime[i])
            {
                count++;
                for (int j = i * 2; j < n; j += i)
                {
                    prime[j] = false;
                }
            }
        }
        return count;
    }
}