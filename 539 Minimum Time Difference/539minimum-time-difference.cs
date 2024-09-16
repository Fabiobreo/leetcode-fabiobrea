public class Solution
{
    public int FindMinDifference(IList<string> timePoints)
    {
        bool[] times = new bool[1440];

        for (var i = 0; i < timePoints.Count; i++)
        {
            var minute = ConvertMinute(timePoints[i]);
            if(times[minute]) return 0;
            times[minute] = true; 
        }

        var next = 0;
        var prev = -1;
        var min = Int32.MaxValue;
        var first = -1;

        for (var i = 0; i < times.Length; i++)
        {
            if (times[i])
            {
                if (prev < 0)
                {
                    first = i;
                }
                else
                {
                    next = i;
                    min = Math.Min(min, next - prev);
                }
                prev = i;
            }
        }

        return Math.Min(min, first - prev + 1440);
    }

    public int ConvertMinute(string time)
    {
        var hour = Convert.ToInt32(time.Substring(0, 2));
        var minute = Convert.ToInt32(time.Substring(3, 2));
        return hour * 60 + minute;
    }
}