public class Solution
{
    public bool RotateString(string s, string goal)
    {
        if (goal.Length < s.Length)
        {
            return false;
        }
        string doubleGoal = goal + goal;
        return doubleGoal.Contains(s);
    }
}