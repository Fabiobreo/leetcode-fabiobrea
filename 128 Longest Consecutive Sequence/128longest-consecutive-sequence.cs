public class Solution {
    public int LongestConsecutive(int[] nums) {
        Dictionary<int, int> frequency = new();
        foreach (int num in nums)
        {
            if (frequency.ContainsKey(num))
            {
                frequency[num]++;
            }
            else
            {
                frequency.Add(num, 1);
            }
        }

        int longest = 0;
        foreach (var item in frequency)
        {
            int current = item.Key;
            if (item.Value == -1)
            {
                continue;
            }

            int count = 1;
            int previousElement = current - 1;
            int nextElement = current + 1;

            while (frequency.ContainsKey(previousElement))
            {
                count++;
                frequency[previousElement] = -1;
                previousElement--;
            }

            while (frequency.ContainsKey(nextElement))
            {
                count++;
                frequency[nextElement] = -1;
                nextElement++;
            }

            longest = Math.Max(longest, count);
        }
        return longest;
    }
}