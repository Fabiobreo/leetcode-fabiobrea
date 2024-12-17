public class MaxHeapComparer : IComparer<char> {
    public int Compare(char x, char y) {
        // Reverse lexicographical order: larger character comes first
        return y.CompareTo(x);
    }
}

public class Solution {
    public string RepeatLimitedString(string s, int repeatLimit) {
        // Count the frequency of each character
        int[] freq = new int[26];
        foreach (char c in s) 
        {
            freq[c - 'a']++;
        }

        PriorityQueue<(char ch, int count), char> maxHeap = new PriorityQueue<(char, int), char>(
            new MaxHeapComparer()
        );

        for (int i = 0; i < 26; i++) 
        {
            var frequency = freq[i];
            if (frequency == 0) 
            {
                continue;
            }
            var ch = (char)(i + 'a');
            maxHeap.Enqueue((ch, frequency), ch);
        }

        var result = new List<char>();

        while (maxHeap.Count > 0) 
        {
            var (ch, count) = maxHeap.Dequeue();

            int addCount = Math.Min(count, repeatLimit);
            for (int i = 0; i < addCount; i++) 
            {
                result.Add(ch);
            }

            if (count <= repeatLimit)
            {
                continue;
            }

            if (maxHeap.Count == 0) break;

            var (nextCh, nextCount) = maxHeap.Dequeue();
            result.Add(nextCh);
            
            if (--nextCount > 0) {
                maxHeap.Enqueue((nextCh, nextCount), nextCh);
            }

            maxHeap.Enqueue((ch, count - repeatLimit), ch);
        }

        return new string(result.ToArray());
    }
}