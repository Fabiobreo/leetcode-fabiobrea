public class Solution
{
    public int GetLucky(string s, int k)
    {
        var numStr = ConvertToInt(s);
        for (int i = 0; i < k; ++i)
        {
            var total = 0;
            foreach (var num in numStr)
            {
                total += num - '0';
            }
            numStr = total.ToString();
        }
        return int.Parse(numStr);
    }

    private string ConvertToInt(string s)
    {
        string num = "";
        foreach (char letter in s)
        {
            num += (int)(letter - 'a' + 1);
        }
        return num;
    }
}