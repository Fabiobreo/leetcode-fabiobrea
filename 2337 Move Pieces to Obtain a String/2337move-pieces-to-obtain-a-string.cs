public class Solution
{
    public bool CanChange(string start, string target)
    {
        int s = 0;
        int t = 0;
        while (s < start.Length || t < target.Length)
        {   
            if (s < start.Length && start[s] == '_') s++;
            else if (t < target.Length && target[t] == '_') t++;
            else if (t == target.Length) return false;
            else if (s == target.Length) return false;
            else if (start[s] != target[t]) return false;
            else if (start[s] == 'R' && s > t) return false;
            else if (start[s] == 'L' && s < t) return false;
            else
            {
                s++;
                t++;
            }
        }
        return true;
    }
}