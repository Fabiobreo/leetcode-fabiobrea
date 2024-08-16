public class Solution {
    public int MaxDistance(IList<IList<int>> arrays) {
        int n = arrays.Count;
        int minGlobal = int.MaxValue;
        int maxGlobal = int.MinValue;

        int result = 0;

        for (int i = 0; i < n; ++i)
        {
            int currentMin = arrays[i][0];
            int currentMax = arrays[i][arrays[i].Count - 1];

            if (i > 0)
            {
                result = Math.Max(result, Math.Abs(currentMax - minGlobal));
                result = Math.Max(result, Math.Abs(maxGlobal- currentMin));
            }
            minGlobal = Math.Min(minGlobal, currentMin);
            maxGlobal = Math.Max(maxGlobal, currentMax);
        }
        return result;
    }
}