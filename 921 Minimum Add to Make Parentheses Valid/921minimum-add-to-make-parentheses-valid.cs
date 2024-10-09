public class Solution
{
    public int MinAddToMakeValid(string s)
    {
        int numOpened = 0;
        int minAdds = 0;
        for (int i = 0; i < s.Length; i++)
        {
            var let = s[i];
            if (let == '(')
            {
                numOpened++;
            }
            else if (let == ')')
            {
                if (numOpened == 0)
                {
                    minAdds++;
                }
                else
                {
                    numOpened--;
                }
            }
        }
        return numOpened + minAdds;
    }
}