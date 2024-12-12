public class Solution
{
    public long PickGifts(int[] gifts, int k)
    {
        long total = 0;
        var heap = new PriorityQueue<int, int>();
        foreach (var gift in gifts)
        {
            total += gift;
            heap.Enqueue(gift, -gift);
        }

        for (int i = 0; i < k; ++i)
        {
            int largest = heap.Dequeue();
            int newValue = (int)Math.Sqrt(largest);
            total -= (largest - newValue);
            heap.Enqueue(newValue, -newValue);
        }

        return total;
    }
}