public class Solution {
    public int[][] Merge(int[][] intervals) {

        List<int[]> mergedIntervals = new();
        Array.Sort(intervals, (a,b) => { return a[0]-b[0]; });
        mergedIntervals.Add(intervals[0]);

        for (int i = 1; i < intervals.Length; i++)
        {
            if (mergedIntervals[mergedIntervals.Count - 1][1] >= intervals[i][0])
            {
                if (mergedIntervals[mergedIntervals.Count - 1][1] <= intervals[i][1]) 
                    mergedIntervals[mergedIntervals.Count - 1][1] = intervals[i][1];
            }
            else
            {
                mergedIntervals.Add(intervals[i]);
            }
        }

        return mergedIntervals.ToArray();
    }
}