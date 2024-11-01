public class Solution
{
    public int MaxDistToClosest(int[] seats)
    {
        var maxDist = 0;
        var currDist = 0;
        var leftGap = -1;
        var rightGap = -1;

        for(int i = 0; i < seats.Length; i++)
        {
            if (seats[i] == 1)
            {
                maxDist = Math.Max(currDist, maxDist);
                if (leftGap == -1)
                {
                    leftGap = currDist;
                }
                currDist = 0;
            }
            else
            {
                currDist++;
            }
        }

        rightGap = currDist;
        
        if ((rightGap > maxDist / 2 ) || (leftGap > maxDist / 2))
            return Math.Max(rightGap, leftGap);
        
        int result = (maxDist + 1) / 2;

        return result;
    }
}