public class Solution
{
    public int[] Intersection(int[] nums1, int[] nums2)
    {
        var set1 = new HashSet<int>();
        var set2 = new HashSet<int>();
        foreach (var num in nums1)
        {
            set1.Add(num);
        }

        foreach (var num in nums2)
        {
            set2.Add(num);
        }
        set1.IntersectWith(set2);
        return set1.ToArray();
    }
}