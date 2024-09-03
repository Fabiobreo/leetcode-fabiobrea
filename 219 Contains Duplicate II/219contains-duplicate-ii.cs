public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        HashSet<int> neighs = new();
        int leftIndex = 0;
        for (int rightIndex = 0; rightIndex < nums.Length; ++rightIndex)
        {
            if (rightIndex - leftIndex > k)
            {
                neighs.Remove(nums[leftIndex]);
                leftIndex++;
            }

            if (neighs.Contains(nums[rightIndex]))
            {
                return true;
            }
            neighs.Add(nums[rightIndex]);
        }
        return false;
    }
}