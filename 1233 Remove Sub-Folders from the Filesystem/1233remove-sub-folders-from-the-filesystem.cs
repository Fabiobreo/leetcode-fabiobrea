public class Solution
{
    public IList<string> RemoveSubfolders(string[] folder)
    {
        List<string> result = new();
        if (folder.Length == 0)
        {
            return result;
        }

        Array.Sort(folder);
        result.Add(folder[0]);
        for (int i = 1; i < folder.Length; ++i)
        {
            if (folder[i].StartsWith($"{result[result.Count - 1]}/"))
            {
                continue;
            }
            result.Add(folder[i]);
        }
        return result;
    }
}