public class Solution
{
    public long MaxKelements(int[] nums, int k)
    {
        PriorityQueue<int, int> maxHeap = new();

        foreach (int num in nums)
        {
            maxHeap.Enqueue(num, -num); 
        }

        long score = 0;

        for (int i = 0; i < k; i++)
        {
            int maxElement = maxHeap.Dequeue();

            score += maxElement;

            int newElement = (int)Math.Ceiling(maxElement / 3.0);

            maxHeap.Enqueue(newElement, -newElement);
        }
        
        return score;
    }
}