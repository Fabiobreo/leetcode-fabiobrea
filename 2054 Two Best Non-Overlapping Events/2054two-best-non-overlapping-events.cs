public class Solution
{
    public int MaxTwoEvents(int[][] events)
    {
        int n = events.Length, maxSeen = 0, maxSum = 0, val, idx, time, lastSeenTillTime = 0, curMax = 0;
        int[][] e = new int[n<<1][];
        for(int i=0; i < n; i++)
        {
            val = events[i][2];
            idx = i<<1;
            e[idx] = [events[i][0],1,val];
            e[idx + 1] = [events[i][1]+1,-1,val];
        }

        n<<=1;
        Array.Sort(e,(a,b) => a[0]!=b[0] ? a[0].CompareTo(b[0]) : a[1].CompareTo(b[1]));
        for(int i=0;i<n;i++)
            if(e[i][1]==-1)
                maxSeen = Math.Max(maxSeen,e[i][2]);
            else
                maxSum = Math.Max(maxSum,maxSeen+e[i][2]);
        return maxSum;
    }
}