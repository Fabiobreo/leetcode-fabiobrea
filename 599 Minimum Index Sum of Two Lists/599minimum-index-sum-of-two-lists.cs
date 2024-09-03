public class Solution
{
    public string[] FindRestaurant(string[] list1, string[] list2)
    {
        var dict = new Dictionary<string, int>();
        for (int i = 0; i < list1.Length; ++i)
        {
            if (!dict.ContainsKey(list1[i]))
            {
                dict.Add(list1[i], i);
            }
        }

        List<string> minCommon = new List<string>();
        int minTotIndex = int.MaxValue;
        for (int j = 0; j < list2.Length; ++j)
        {
            if (dict.ContainsKey(list2[j]))
            {
                int totalIndex = j + dict[list2[j]];
                if (totalIndex < minTotIndex)
                {
                    minTotIndex = totalIndex;
                    minCommon.Clear();
                    minCommon.Add(list2[j]);
                }
                else if (totalIndex == minTotIndex)
                {
                    minCommon.Add(list2[j]);
                }
            }
        }
        return minCommon.ToArray();
    }
}