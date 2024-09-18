public class Solution
{
    public class CustomComparer : IComparer<string>
    {
        public int Compare(string a, string b)
        {
            string order1 = a + b;
            string order2 = b + a;
            return order2.CompareTo(order1);
        }
    }

    public string LargestNumber(int[] nums)
    {
        string[] strNums = nums.Select(n => n.ToString()).ToArray();
        Array.Sort(strNums, new CustomComparer());
        if (strNums[0] == "0")
        {
            return "0";
        }

        StringBuilder largest = new StringBuilder();
        foreach (var num in strNums)
        {
            largest.Append(num);
        }
        return largest.ToString();
    }
}