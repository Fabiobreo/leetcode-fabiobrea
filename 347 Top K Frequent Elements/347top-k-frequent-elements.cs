public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        var count = new Dictionary<int, int>();
        List<int>[] freq = new List<int>[nums.Length + 1];
        for (int i = 0; i < freq.Length; ++i)
        {
            freq[i] = new List<int>();
        }

        foreach (int num in nums)
        {
            if (!count.ContainsKey(num))
            {
                count.Add(num, 0);
            }
            count[num]++;
        }

        foreach (var entry in count)
        {
            freq[entry.Value].Add(entry.Key);
        }

        int[] res = new int[k];
        int index = 0;
        for (int i = freq.Length - 1; i > 0 && index < k; i--)
        {
            foreach (int num in freq[i])
            {
                res[index++] = num;
                if (index == k)
                {
                    return res;
                }
            }
        }
        return res;
    }
}
