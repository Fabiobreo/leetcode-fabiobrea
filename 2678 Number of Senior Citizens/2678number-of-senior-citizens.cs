public class Solution
{
    public int CountSeniors(string[] details)
    {
        int count = 0;
        foreach (string det in details)
        {
            int age = int.Parse(det.Substring(11, 2));
            if (age > 60)
            {
                count++;
            } 
        }
        return count;
    }
}