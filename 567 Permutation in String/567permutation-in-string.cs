public class Solution
{
    public bool CheckInclusion(string s1, string s2)
    {
        int ns1 = s1.Length, ns2 = s2.Length;
        if (ns1 > ns2) 
            return false;
        int[] f = new int[26], f2 = new int[26];
        for(int i = 0; i < ns1; i++)
        {
            f[s1[i] - 'a']++; 
            f2[s2[i] - 'a']++;
        }

        for(int i = 0; i + ns1 <= ns2; i++)
        {
            if (i > 0)
            {
                f2[s2[i - 1] - 'a']--;
                f2[s2[i + ns1 - 1] - 'a']++;
            }

            if (CheckPermutation(f, f2))
                return true;
        }
        return false;
    }
    bool CheckPermutation(int[] freq, int[] freq2)
    {
        for (int i = 0; i < 26; i++)
        {      
            if (freq[i] != freq2[i])
                return false;
        }
        return true;
    }
}