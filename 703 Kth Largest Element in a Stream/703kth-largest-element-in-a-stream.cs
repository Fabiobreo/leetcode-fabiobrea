public class KthLargest {
    private List<int> nums;
    private int k;

    public KthLargest(int k, int[] nums) {
        this.k = k;
        this.nums = new List<int>(nums);
        this.nums.Sort();
    }
    
    public int Add(int val) {
        int index = nums.BinarySearch(val);
        if (index < 0) index = ~index;
        nums.Insert(index, val);
        return nums[nums.Count - k];
    }
}