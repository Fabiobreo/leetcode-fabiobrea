public class Solution
{
    public int LongestCommonPrefix(int[] arr1, int[] arr2)
    {
        var set1 = new HashSet<int>();
        for (int i = 0; i < arr1.Length; ++i)
        {
            var num = arr1[i];
            while (num > 0)
            {
                set1.Add(num);
                num /= 10;
            }
        }

        int longest = 0;
        for (int i = 0; i < arr2.Length; ++i)
        {
            var num = arr2[i];
            while (num > 0)
            {
                if (set1.Contains(num))
                {
                    longest = Math.Max(longest, num.ToString().Length);
                    break;
                }
                num /= 10;
            }
        }
        return longest;
    }
}