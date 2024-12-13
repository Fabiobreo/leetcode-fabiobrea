public class Solution
{
    public long FindScore(int[] nums)
    {
        int n = nums.Length;
        var marked = new HashSet<int>();
        var minHeap = new PriorityQueue<(int, int), (int, int)>(Comparer<(int v, int i)>.Create(
            (x, y) => x.v == y.v ? x.i.CompareTo(y.i) : x.v.CompareTo(y.v)));

        for (int i = 0; i < n; ++i)
        {
            minHeap.Enqueue((nums[i], i), (nums[i], i));
        }

        long result = 0L;
        while (minHeap.Count > 0)
        {
            (int v, int i) current = minHeap.Dequeue();

            if (!marked.Contains(current.i))
            {
                result += current.v;
                marked.Add(current.i + 1);
                marked.Add(current.i - 1);
            }
        }

        return result;
    }
}