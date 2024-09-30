public class Solution 
{
    public int IsDecreasing(List<int> nums)
    {
        for(int i = 0; i < nums.Count - 1; i++)
        {
            if(nums[i] > nums[i + 1]) return i;
        }

        return -1;
    }

    public bool CheckPossibility(int[] nums)
    {
        List<int> res = new List<int>(nums);

        int i = IsDecreasing(res);

        if(i == -1) return true;

        List<int> first = new List<int>(res);
        List<int> second = new List<int>(res);

        first[i] = first[i + 1];
        second[i + 1] = second[i];

        if(IsDecreasing(first) == -1) return true;
        if(IsDecreasing(second) == -1) return true;

        return false;
    }
}