public class Solution {
    public int ShortestSubarray(int[] nums, int k) {
        int n = nums.Length;
        long[] prefixSum = new long[n + 1];
        for (int i = 0; i < n; i++) {
            prefixSum[i + 1] = prefixSum[i] + nums[i];
        }
        LinkedList<int> deque = new LinkedList<int>();
        int minLength = int.MaxValue;
        
        for (int i = 0; i <= n; i++) {
            while (deque.Count > 0 && prefixSum[i] - prefixSum[deque.First.Value] >= k) {
                minLength = Math.Min(minLength, i - deque.First.Value);
                deque.RemoveFirst();
            }
            while (deque.Count > 0 && prefixSum[i] <= prefixSum[deque.Last.Value]) {
                deque.RemoveLast();
            }
            deque.AddLast(i);
        }
        
        return minLength == int.MaxValue ? -1 : minLength;
    }
}