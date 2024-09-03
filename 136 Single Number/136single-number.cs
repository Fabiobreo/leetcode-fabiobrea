public class Solution
{
    public int SingleNumber(int[] nums)
    {
        var set = new HashSet<int>();
        foreach (var num in nums)
        {
            if (!set.Contains(num))
            {
                set.Add(num);
            }
            else
            {
                set.Remove(num);
            }
        }
        return set.First();
    }
}