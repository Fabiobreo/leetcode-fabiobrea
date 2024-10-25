public class Solution
{
    public IList<string> StringSequence(string target)
    {
        List<string> result = new();
        string current = string.Empty;
        int currentLength = 0;
        while (current != target)
        {
            for (int i = 0; i < 26; ++i)
            {
                var test = (char)('a' + i);
                result.Add(current + test);
                if (test == target[currentLength])
                {
                    currentLength++;
                    current += test;
                    break;
                }
            }
        }
        return result;
    }
}