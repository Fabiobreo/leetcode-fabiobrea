public class Solution
{
    public Dictionary<char, List<int>> data = new Dictionary<char, List<int>>();
    public Dictionary<(int, int), int> cache = new Dictionary<(int, int), int>(); 
    public string target;

    public int StrangePrinter(string s)
    {
        var sb = new StringBuilder();
        foreach(var ch in s)
        {
            if(sb.Length == 0 || sb[sb.Length - 1] != ch)
            {
                sb.Append(ch);
            }
        }
        target = sb.ToString();
        var n = target.Length;

        return Solve(0, n - 1);     
    }

    public int Solve(int start, int end)
    {
        if (start == end)
        {
            return 1;
        }

        if (start > end)
        {
            return 0;
        }

        if (!cache.ContainsKey((start, end)))
        {
            var result = target[start] == target[end] ? Solve(start, end - 1) : end - start + 1;
            
            for (int i = start; i < end; ++i)
            {
                result = Math.Min(result, Solve(start, i) + Solve(i + 1, end));
            }

            cache.Add((start, end), result);
        }

        return cache[(start, end)];
    }
}